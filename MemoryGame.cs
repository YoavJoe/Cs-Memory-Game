using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using YoavMemoryGame.Properties;



namespace YoavMemoryGame
{
    public partial class Form1 : Form
    {
        int timePerPlayer = 0;
        private const int CARD_NUMBER = 8;
        private const int TOTAL_TIME = 60;
        int steps = 0, Count_OF_WINS = 0;
        public Form1()
        {
            InitializeComponent();
            SetImagesArray();
            timer2.Interval = 1000;
            timer2.Start();
        }


        public bool IsImagesMatch(Image image1, Image image2)
        {
            try
            {
                //create instance or System.Drawing.ImageConverter to convert
                //each image to a byte array
                ImageConverter converter = new ImageConverter();
                //create 2 byte arrays, one for each image
                byte[] imgBytes1 = new byte[1];
                byte[] imgBytes2 = new byte[1];
                //convert images to byte array
                imgBytes1 = (byte[])converter.ConvertTo(image1,
                imgBytes2.GetType());
                imgBytes2 = (byte[])converter.ConvertTo(image2,
                imgBytes1.GetType());
                //now compute a hash for each image from the byte arrays
                System.Security.Cryptography.SHA256Managed sha = new
                System.Security.Cryptography.SHA256Managed(); byte[] imgHash1 =
                 sha.ComputeHash(imgBytes1);
                byte[] imgHash2 = sha.ComputeHash(imgBytes2);
                //now let's compare the hashes
                for (int i = 0; i < imgHash1.Length && i < imgHash2.Length;
                i++)
                {
                    //whoops, found a non-match, exit the loop
                    //with a false value
                    if (!(imgHash1[i] == imgHash2[i]))
                        return false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            //we made it this far so the images must match
            return true;
        }
        
        private Image[] m_Images = new Image[CARD_NUMBER];
        private void Swap(int i, int j)
        {                                   //מחליפה ערכים בין שני מקומות במערך התמונות
            Image image = m_Images[i];
            m_Images[i] = m_Images[j];
            m_Images[j] = image;
        }
        private void SetImagesArray()
        {
            m_Images[0] = Resources.car1;
            m_Images[1] = Resources.car2;
            m_Images[2] = Resources.car3;
            m_Images[3] = Resources.car4;
            m_Images[4] = Resources.car1;
            m_Images[5] = Resources.car2;
            m_Images[6] = Resources.car3;
            m_Images[7] = Resources.car4;
            Random rnd = new Random();
            for (int i = 0; i < CARD_NUMBER; i++)
            {
                Swap(i, rnd.Next(CARD_NUMBER));
            }

        }
        private bool m_IsFirst = true;
        private PictureBox m_FirstPictureBox;
        private PictureBox m_SecondPictureBox;
        private void pictureBox_Card_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            string picName = pictureBox.Name;    //מציאת המספר שהוא התו האחרון בשם תמונת הקלף
            int k = int.Parse(picName.Substring(picName.Length - 1));  //מחסירים אחד כדיי להגיע למקום המתאים במערך התמונות
            k--;
            if (!IsImagesMatch(pictureBox.Image, Resources.back))
                pictureBox.Image = Resources.back;
            else
                pictureBox.Image = m_Images[k];
            if (!m_IsFirst)
            {               //לחצו על הקלף השני בזוג
                m_SecondPictureBox = pictureBox;
                timer1.Start();
                steps++;
                lblSteps.Text = steps.ToString();

            }
            else
            {               //לחצו על הקלף הראשון בזוג
                m_FirstPictureBox = pictureBox;
            }

            m_IsFirst = !m_IsFirst;
        }

        int m_CountTrue = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            
            if (IsImagesMatch(m_FirstPictureBox.Image, m_SecondPictureBox.Image))
            {                                       //הקלפים זהים - נוציא אותם מהמשחק )לא יהיו מאופשרים(
                m_FirstPictureBox.Enabled = false;
                m_SecondPictureBox.Enabled = false;
                m_CountTrue += 2;
            }
            else
            {                                       //הקלפים אינם זהים - נהפוך אותם חזרה
                m_FirstPictureBox.Image = Resources.back;
                m_SecondPictureBox.Image = Resources.back;
            }
            timer1.Enabled = false;
            if (m_CountTrue == CARD_NUMBER)
            {                                       //ניצחון!!!
                MessageBox.Show("Winnnnnnnnnnnnnnnn!!!!");
                Count_OF_WINS ++;
                lblNumerv.Text = (Count_OF_WINS).ToString();
                StartNewGame();
                m_CountTrue = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }

        private void StartNewGame()
        {
            PictureBox p;
            for (int i = 1; i <= CARD_NUMBER; i++)
            {
                p = (PictureBox)this.Controls["pictureBox" + i];
                p.Image = Resources.back;
                p.Enabled = true;
            }
            SetImagesArray();
            steps = 0;
            lblSteps.Text = steps.ToString();
            timePerPlayer = 0;
            lblSeconds.Text = (TOTAL_TIME).ToString();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (timePerPlayer > TOTAL_TIME)
            {
                timer2.Enabled = false;
                MessageBox.Show("Game Over , Your time is up DUDE!!!!");
                Application.Exit();
            }
            else
            {

                lblSeconds.Text = (TOTAL_TIME - timePerPlayer).ToString();
                timePerPlayer++;
            }
        }

        private void lblNumerv_Click(object sender, EventArgs e)
        {
            lblNumerv.Text = (Count_OF_WINS).ToString();
        }

       
    }
}
