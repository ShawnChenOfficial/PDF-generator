using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using PlayingCard;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using iTextSharp.text.pdf;
using System.Diagnostics;
using System.Drawing.Imaging;

namespace Lab_Serialization_
{
    public partial class CardsDealer : Form
    {
        IFormatter BitCode = new BinaryFormatter();
        List<List<PlayingCards>> Hands;
        PictureBox box;
        Deck deck;
        PictureBox[] imageBox;
        const int NUM_CARDS = 52;
        const int NUM_CARDS_DISPLAY = 13;
        const int CARD_WIDTH = 75;
        const int CARD_HEIGHT = 107;
        const int ROW = 7;
        public CardsDealer()
        {
            InitializeComponent();
        }
        private void CardsDealer_Load(object sender, EventArgs e)
        {
            SetComponents();
            DealCard();
            label.Visible = false;
        }
        private void buttonDealCards_Click(object sender, EventArgs e)
        {
            DealCard();
            Display(0);
            DisplayNumOfHands(0);
        }
        public void SetComponents()
        {

            imageBox = new PictureBox[NUM_CARDS_DISPLAY];

            for (int i = 0; i < NUM_CARDS_DISPLAY; i++)
            {
                box = new PictureBox();
                box.Width = CARD_WIDTH;
                box.Height = CARD_HEIGHT;
                box.Location = new Point(135 + i % ROW * CARD_WIDTH, 100 + i / ROW * CARD_HEIGHT);
                box.Image = imageList.Images[0];
                imageBox[i] = box;
                this.Controls.Add(box);
            }

        }
        private void DealCard()
        {
            deck = new Deck();
            List<Image> images = new List<Image>();
            for (int i = 1; i <= 52; i++)
            {
                images.Add(imageList.Images[i]);
            }
            deck.AssignImage(images, imageList.Images[0]);

            deck.Shuffle();

            Hands = new List<List<PlayingCards>>();
            for (int x = 0; x < 4; x++)
            {
                List<PlayingCards> card = new List<PlayingCards>();

                for (int y = 0 + x * NUM_CARDS_DISPLAY; y < NUM_CARDS_DISPLAY + x * NUM_CARDS_DISPLAY; y++)
                {
                    card.Add(deck.DealTopCard());
                }
                Hands.Add(card);
            }
        }

        private void Display(int index)
        {
            //PositionOnHands = (button1stHand.Focused) ? button1stHand.Tag
            //     : ((button2ndHand.Focused) ? button2ndHand.Tag
            //     : ((button3rdHand.Focused) ? button3rdHand.Tag : button4thHand.Tag));

            for (int i = 0; i < NUM_CARDS_DISPLAY; i++)
            {
                imageBox[i].Image = Hands[index][i].FrontImage;
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Bit Code|*.bc";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Stream file = File.Create(saveFileDialog.FileName);
                BitCode.Serialize(file, Hands);
                file.Close();
            }
        }
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                    Stream file = File.OpenRead(openFileDialog.FileName);
                    Hands = (List<List<PlayingCards>>)BitCode.Deserialize(file);
                    file.Close();
            }
            Display(0);
            DisplayNumOfHands(0);
        }
        private void buttonHand_Click(object sender, EventArgs e)
        {
            int index = (int)((sender as Button).Tag);
            Display(index);
            DisplayNumOfHands(index);
        }
        private void DisplayNumOfHands(int index)
        {
            labelNumOfHands.Text = (index + 1).ToString();
            label.Visible = true;
        }

        private void Save_PDF_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "pdf|*.pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Stream file = File.Create(saveFileDialog.FileName);

                iTextSharp.text.Document document = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 10, 10, 0, 0);
                iTextSharp.text.Font redFont = iTextSharp.text.FontFactory.GetFont(BaseFont.TIMES_ROMAN, 12f, iTextSharp.text.Font.ITALIC, iTextSharp.text.BaseColor.BLACK);

                PdfWriter writer = PdfWriter.GetInstance(document, file);
                document.Open();

                for (int y = 0; y < Hands.Count; y++)
                {
                    ColumnText ct = new ColumnText(writer.DirectContent);
                    ct.SetSimpleColumn(new iTextSharp.text.Rectangle(20, 760 - (2 * y) * (53.5f + 5), 200, 730 - (2 * y) * (53.5f + 5)));
                    ct.AddElement(new iTextSharp.text.Paragraph("Hand " + (y + 1) + ":"));
                    ct.Go();

                    for (int x = 0; x < 13; x++)
                    {
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Hands[y][x].FrontImage, ImageFormat.Png);
                        
                        int col = x % 7;
                        int row = x / 7;

                        img.ScalePercent(50f);
                        img.SetAbsolutePosition(80 + col * (37.5f + 5), 700 - (2*y + row) * (53.5f + 5));
                        document.Add(img);
                    }
                }

                Process.Start(saveFileDialog.FileName);

                document.Close();
                writer.Close();
                file.Close();

            }
        }
    }
}
