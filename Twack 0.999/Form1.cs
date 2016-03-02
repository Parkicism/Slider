using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Twack_0._999
{
    //TWACKFIANL
    public partial class Form1 : Form
    {
        
        bool startGame = false;
        Button[] btnArray;
        int score;
        int moveCount;
        int distancex;
        int distancey;
        bool bGen = false;
        //generate variables
        
        int btnSizex;
        int btnSizey;
        int gap;
        int i;
        int lastBtn;
        Point[] btnOGPoint;
        bool not1by1 = true;
        int lBtn;
        // ----------------------------
        Image[] imgArray;
        Image img;

        //============
        int row;
        int column;
        int hLoc;
        int vLoc;
        int yLoc;
        int xLoc;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            img = pbImage.Image;
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            cbRow.SelectedIndex = 2; 
            cbColumn.SelectedIndex = 2;
            Generate();
            SplitImage();
            
        }

        


        public void Generate()
        {
 
            row = Convert.ToInt32(cbRow.SelectedItem);
            column = Convert.ToInt32(cbColumn.SelectedItem);


            gap = 1;// distance between buttons

            if (row != 1 && column != 1)
            {
                not1by1 = true;

            }
            else if (row == 1 && column == 1)
            {
                not1by1 = false;
                MessageBox.Show("Cannot Generate a 1x1 Puzzle.");
            }


            btnArray = new Button[row *column]; // array to store buttons
            btnOGPoint = new Point[row * column];

            btnSizex = (Convert.ToInt32(this.Height * 0.81) / row);  //btnsize relative to the height of the form and to the size of the grid
            btnSizey = (Convert.ToInt32(this.Height * 0.81) / column);

            hLoc = Convert.ToInt32(this.Height * 0.02); // distance from 0,0 of the form
            vLoc = Convert.ToInt32(this.Height * 0.04);

            xLoc = hLoc; //seperate variable to store hLoc(first button location)
            yLoc = vLoc; //xLoc,yLoc will be changed throughout the loop, while hLoc and vLoc are static and are declared to be referenced



            lastBtn = (row * column); //very last button to be btnBlank
            lBtn = lastBtn - 1;

            if (not1by1 == true)
            {

                for (i = 0; i < (row * column); i++)
                {

                    if (i == lBtn) // if it's the last button then it's a special button called btnBlank (empty space)
                    {
                        btnArray[i] = new Button();
                        btnArray[i].Name = "btnBlank";
                        // btnArray[i].Text = "Blank";
                        btnArray[i].Size = new Size(btnSizex, btnSizey);
                        btnArray[i].Location = new Point(xLoc, yLoc);
                        btnOGPoint[i] = new Point(xLoc, yLoc);
                        btnArray[i].FlatStyle = FlatStyle.Flat;
                        this.Controls.Add(btnArray[i]);



                    }
                    else if (i < lBtn) // every other clickable buton
                    {
                        btnArray[i] = new Button(); //creating button
                        btnArray[i].Size = new Size(btnSizex, btnSizey); //size
                        btnArray[i].Location = new Point(xLoc, yLoc); //location of the button
                        btnOGPoint[i] = new Point(xLoc, yLoc);
                        // btnArray[i].Text = (i + 1).ToString(); ; //numbering each button
                        btnArray[i].Click += new EventHandler(this.btnHandler);         
                        btnArray[i].FlatStyle = FlatStyle.Flat;
                        this.Controls.Add(btnArray[i]); // adding it to the form



                        xLoc += btnArray[i].Width + gap; // every loop, the button's location will move horizontally to the right until it hits a certain boundary

                        if (xLoc >= ((this.Height * 0.81) + hLoc)) //then if it hits the boundary, horizonta location will be reset, while the vertical location will move down 1 row
                        {                                       //and repeat until loop is finished.
                            xLoc = hLoc;
                            yLoc += btnArray[i].Height + gap;
                        }

                    }

                }
                SplitImage(); //every time it generates it adds image

                bGen = true;
                not1by1 = true;
                startGame = false;

                ScoreReset();

            }
          
        }

        private void DisposeButtons() // gets rid of all buttons
        {
           
                foreach (Button b in btnArray)
                {
                    this.Controls.Remove(b);
                }
                bGen = false;

        }

        private void btnMove(Button btnClick)
        {

            distancex = (btnSizex + gap) + 1; // the distance between two closes buttons + 1 for good measure
            distancey = (btnSizey + gap) + 1;

            if (bGen == true)
            {
            if (btnClick.Location.X == btnArray[lBtn].Location.X || btnClick.Location.Y == btnArray[lBtn].Location.Y) // they can only move horizontaly or vertically so it must meet
            {                                                                                                           // this condition

                Point tempBlank = new Point();      //creates a temporary point to store Clicked button's location
                tempBlank = btnClick.Location;

                if (btnClick.Location.X == btnArray[lBtn].Location.X) //if x = x that means it can only move up or down
                {
                    if (btnClick.Location.Y < btnArray[lBtn].Location.Y + distancey && btnClick.Location.Y > btnArray[lBtn].Location.Y - distancey) // condition to check
                    {                                                                                               // if clicked button's location is within distance of btnBlank
                        btnClick.Location = btnArray[lBtn].Location;    //swapping locations
                        btnArray[lBtn].Location = tempBlank;
                        
                        if (startGame == true)
                        {
                            moveCount += 1;     //add moveCount
                            lblMC.Text = "Move Count: " + moveCount;
                        }

                        if (startGame == true && WinCheck() == true)
                        {
                            tmrTime.Enabled = false;
                            btnArray[lBtn].Visible = true;
                            startGame = false;     
                            MessageBox.Show("Congratulations! You have complete the puzzle in " + score + " seconds and in " + moveCount + " moves!");
                                                 
                        }

                    }
                }

                if (btnClick.Location.Y == btnArray[lBtn].Location.Y) // y=y moving left or right
                {
                    if (btnClick.Location.X > btnArray[lBtn].Location.X - distancex && btnClick.Location.X < btnArray[lBtn].Location.X + distancex) // samething as above
                    {
                        btnClick.Location = btnArray[lBtn].Location;
                        btnArray[lBtn].Location = tempBlank;
                        
                        if (startGame == true)
                        {
                            moveCount += 1;
                            lblMC.Text = "Move Count: " + moveCount;
                        }

                        if (startGame == true && WinCheck() == true)
                        {
                            tmrTime.Enabled = false;
                            btnArray[lBtn].Visible = true;
                            startGame = false; 
                            MessageBox.Show("Congratulations! You have complete the puzzle in " + score + " seconds and in " + moveCount + " moves!");
                                                    
                        }

                    }
                }


            }
        }


        }

        private void btnHandler(object sender, EventArgs e) // just button handling
        {
            Button clickedBtn = (Button)sender;
            btnMove(clickedBtn);
        }


        private void Scramble()
        {

            Random rnd = new Random(); //random
            Button tempBtn = new Button(); //create a button

            for (var x = 1; x < 400 * row; x++) // loops it 400*size*size*2*size ( so a lot)
            {
                tempBtn = (Button)btnArray[rnd.Next(btnArray.Length)]; // picks any random button in the array of buttons created
                btnMove(tempBtn); // just runs the move code and if it works it work if not then onto the next button

            }
            //starts up everything
            score = 0;
            moveCount = 0;
            btnArray[lBtn].Visible = false;

            for (int f = 0; f < btnArray.Length; f++)
            {
                if (btnArray[f].Location == btnOGPoint[f])
                {
                    Scramble();
                }
            }

            startGame = true;

        }

        private bool WinCheck() // check if you won the game
        {
            for (int c = 0; c < row*column; c++)
            {

                if (btnArray[c].Location != btnOGPoint[c])
                {
                    return false;
                }

            }
            return true;

        }


        private void SplitImage()
        {

            int sizex = (Convert.ToInt32(btnArray[1].Width) * row); //size of the grid
            int sizey = (Convert.ToInt32(btnArray[1].Height) * column);

            imgArray = new Image[row * column]; //creating an image array for the cropped
            // don't think i need this  but keep just in case //   img = pbImage.Image;    // getting the image from picturebox
            var bImg = new Bitmap(img, new Size(sizex, sizey)); //resizing image


            for (int y = 0; y < column; y++) // nested for loop  working horizontally first then vertically
            {
                for (int x = 0; x < row; x++)
                {

                    var index = y * row + x ;
                    imgArray[index] = new Bitmap(btnSizex, btnSizey);
                    var g = Graphics.FromImage(imgArray[index]);
                    g.DrawImage(bImg, new Rectangle(0, 0, btnSizex, btnSizey), new Rectangle(x * btnSizex, y * btnSizey, btnSizex, btnSizey), GraphicsUnit.Pixel);
                    g.Dispose();

                    btnArray[index].BackgroundImage = imgArray[index]; //sets the image to buttons

                }
            }
        }

        private void Reset()
        {
            not1by1 = true;
            DisposeButtons();
            Generate();
        }

        private void ScoreReset()
        {
            moveCount = 0;
            lblMC.Text = "Move Count: " + moveCount;
            score = 0;
            lblTime.Text = "Time: " + score;
        }




        private void btnGen_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnScramble_Click(object sender, EventArgs e)
        {

            if (bGen == true && startGame == false)
            {
                Scramble();
                tmrTime.Enabled = true;
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "Image Files(*.jpg; .jpeg; .gif; .bmp)|*.jpg; .jpeg; .gif; .bmp"; // so that you can only open images
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    img = Image.FromFile(openFileDialog1.FileName); // getting the image
                    pbImage.Image = img;
                    pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    SplitImage(); // button image
                }
            }
            catch (Exception)
            {
                throw new ApplicationException("Failed loading image"); //error
            }
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            if (startGame == true) //score keeping
            {
                score += 1;
                lblTime.Text = "Time: " + score + "s";
            }
        }

    }
}
