using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using System.Windows.Input;
using System.Threading;

using System.Diagnostics;

using System.Drawing.Imaging;
using System.IO;


namespace DAImageChecker
{

    public partial class DAImageChecker : Form
    {
        public DAImageChecker()
        {
            InitializeComponent();

            MouseHook.Start();
            MouseHook.MouseActionLeftClick += new EventHandler(HandleMouseEventLeftClick);
            MouseHook.MouseActionRightClick += new EventHandler(HandleMouseEventRightClick);
        }

        [DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        public enum MouseActionAdresses
        {
            LEFTDOWN = 0x00000002,
            LEFTUP = 0x00000004,
            //MIDDLEDOWN = 0x00000020,
            //MIDDLEUP = 0x00000040,
            MOVE = 0x00000001,
            //ABSOLUTE = 0x00008000,
            RIGHTDOWN = 0x00000008,
            RIGHTUP = 0x00000010
        }
        public void LeftClick(int x, int y)
        {
            System.Windows.Forms.Cursor.Position = new Point(x, y);
            mouse_event((int)(MouseActionAdresses.LEFTDOWN), 0, 0, 0, 0);
            mouse_event((int)(MouseActionAdresses.LEFTUP), 0, 0, 0, 0);
        }
        public void RightClick(int x, int y)
        {
            System.Windows.Forms.Cursor.Position = new Point(x, y);
            mouse_event((int)(MouseActionAdresses.RIGHTDOWN), 0, 0, 0, 0);
            mouse_event((int)(MouseActionAdresses.RIGHTUP), 0, 0, 0, 0);
        }
        public void MouseMoveTo(int x, int y)
        {
            System.Windows.Forms.Cursor.Position = new Point(x, y);
            mouse_event((int)(MouseActionAdresses.MOVE), 0, 0, 0, 0);
            //mouse_event((int)(MouseActionAdresses.RIGHTUP), 0, 0, 0, 0);
        }


        private void HandleMouseEventLeftClick(object sender, EventArgs e)
        {
            FillActionList(actionListID, (50), System.Windows.Forms.Cursor.Position.X, System.Windows.Forms.Cursor.Position.Y,
                "Left Click", "MM1");
            FillActionList(actionListID, (clickAwaitInterval * 10), System.Windows.Forms.Cursor.Position.X, System.Windows.Forms.Cursor.Position.Y,
                "Left Click", "MC1");

            clickAwaitInterval = 0;
        }
        private void HandleMouseEventRightClick(object sender, EventArgs e)
        {
            FillActionList(actionListID, (50), System.Windows.Forms.Cursor.Position.X, System.Windows.Forms.Cursor.Position.Y,
                "Left Click", "MM1");
            FillActionList(actionListID, (clickAwaitInterval * 10), System.Windows.Forms.Cursor.Position.X, System.Windows.Forms.Cursor.Position.Y,
                "Right Click", "MC2");
            clickAwaitInterval = 0;
        }
        private void DisableAllProcess()
        {
            lblExStat.BackColor = Color.Aquamarine;
            lblExStat.Text = "execution stopped";
            btnStartRecord.Text = "Start Record";
            btnPlay.Text = "Start Play";

            startRecord = false;
            timerActionExecute.Enabled = false;
            timerClickInterval.Enabled = false;
            timer4.Enabled = false;

        }


        //Bitmap bmp2 = new Bitmap(100, 50);
        //private Bitmap CreateScreenshot2(int left, int top, int width, int height)
        //{
        //    Graphics g = Graphics.FromImage(bmp2);
        //    g.CopyFromScreen(left, top, 0, 0, new Size(width, height));
        //    g.Dispose();
        //    return bmp2;
        //}


        private void FillActionList(int ID, int mSec, int posX, int posY, string action, string addedInfo)
        {
            if (startRecord == true)
            {
                actionListID++;
                dataGridActionList.Rows.Add(ID, mSec, posX, posY, action, addedInfo);
            }
        }

        int maxPics = 0;
        string keyCode = "X";
        //int screenInterval = 0;
        //int shortTimeCounter = 0;
        bool keyBDownRepeat = true;
        bool keyNDownRepeat = true;
        void KeyboardRead()
        {
            while (isRunningKeyboardRead)
            {
                Thread.Sleep(40);
                if ((Keyboard.GetKeyStates(Key.LeftAlt) & KeyStates.Down) > 0)
                {
                    if (((Keyboard.GetKeyStates(Key.C) & KeyStates.Down) > 0))
                    {
                        keyCode = "AltC";
                    }
                    if (Keyboard.IsKeyUp(Key.B))
                    {
                        keyBDownRepeat = true;
                    }
                    if (((Keyboard.GetKeyStates(Key.B) & KeyStates.Down) > 0) && keyBDownRepeat == true && startRecord == true)
                    {
                        keyBDownRepeat = false;
                        //FillActionList(actionListID, 300, System.Windows.Forms.Cursor.Position.X, System.Windows.Forms.Cursor.Position.Y,
                        //"Alt B pressed", "AlB");
                    }
                    if (Keyboard.IsKeyUp(Key.N))
                    {
                        keyNDownRepeat = true;
                    }
                    if (((Keyboard.GetKeyStates(Key.N) & KeyStates.Down) > 0) && keyNDownRepeat == true && startRecord == true)
                    {
                        keyNDownRepeat = false;
                        keyCode = "AltN";

                    }
                }
            }
        }

        Bitmap shortcutsImage = new Bitmap(100, 50);
        private Bitmap CreateScreenshot1(int left, int top)
        {
            Graphics g = Graphics.FromImage(shortcutsImage);
            g.CopyFromScreen(left, top, 0, 0, new Size(100, 50));
            g.Dispose();
            return shortcutsImage;
        }

        private void timerKeyCode_Tick(object sender, EventArgs e)
        {
            switch (keyCode)
            {
                case "AltN":
                    if (maxPics <= 100)
                    {
                        maxPics++;
                        lblCurrentRepeat.Text = pictureID.ToString();
                        picScreen1.Image = CreateScreenshot1(System.Windows.Forms.Cursor.Position.X - 50, System.Windows.Forms.Cursor.Position.Y - 25);
                        FillActionList(actionListID, 300, System.Windows.Forms.Cursor.Position.X, System.Windows.Forms.Cursor.Position.Y, "Check Pic", "Pic", 90);
                        keyCode = "X";
                    }
                    break;
                case "AltC":
                    DisableAllProcess();
                    keyCode = "X";
                    break;
                case "X":

                    break;
                default:
                    break;
            }

        }
        ///HIER MUSS THREAD STARTEN
        int[,,,] arFarben = new int[102, 52, 4, 107];
        byte[] rgbValues = new byte[20000];

        int actionListID = 0;
        int pictureID = 0;
        bool secondImage = false;

        static AutoResetEvent _fillAwait = new AutoResetEvent(true);
        private void quickSnapShot()
        {
            Bitmap bmp = new Bitmap(shortcutsImage);
            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            System.Drawing.Imaging.BitmapData bmpData =
                bmp.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite,
                bmp.PixelFormat);
            IntPtr ptr = bmpData.Scan0;
            byte[] rgbValues1 = new byte[20000];
            rgbValues = rgbValues1;
            System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues1, 0, 20000);
            secondImage = true;
            threadID = 105;
            Array1FillNew();
        }

        private void FillActionList(int ID, int mSec, int posX, int posY, string action, string addedInfo, int percentAccuracy)
        {
            if (startRecord == true)
            {

                Bitmap bmp = new Bitmap(shortcutsImage);
                Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
                System.Drawing.Imaging.BitmapData bmpData =
                    bmp.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite,
                    bmp.PixelFormat);
                IntPtr ptr = bmpData.Scan0;
                byte[] rgbValues1 = new byte[20000];
                rgbValues = rgbValues1;
                System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues1, 0, 20000);

                dataGridActionList.Rows.Add(ID, mSec, posX, posY, action, addedInfo, percentAccuracy, pictureID);
                actionListID++;
                pictureID++;
                Array1FillNew();
            }
        }
        int threadID;
        private void Array1FillNew()
        {

            if (secondImage == true)
            { }
            else
            { threadID = pictureID - 1; }
            for (int corY = 0; corY < 20000;)
            {
                for (int corX = 0; corX < 400;)
                {
                    arFarben[corX / 4, corY / 400, 3, threadID] = rgbValues[corY + corX];
                    corX += 4;
                }
                for (int corX = 1; corX < 400;)
                {
                    arFarben[corX / 4, corY / 400, 2, threadID] = rgbValues[corY + corX];
                    corX += 4;
                }
                for (int corX = 2; corX < 400;)
                {
                    arFarben[corX / 4, corY / 400, 1, threadID] = rgbValues[corY + corX];
                    corX += 4;
                }
                for (int corX = 3; corX < 400;)
                {
                    arFarben[corX / 4, corY / 400, 0, threadID] = rgbValues[corY + corX];
                    corX += 4;
                }

                corY += 400;
            }
        }
        int arrayInfo1 = 0;
        private void btnShowInfos_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(arrayInfo1);
        }

        bool startRecord = false;
        int clickAwaitInterval = 0;
        private void btnStartRecord_Click(object sender, EventArgs e)
        {
            keyCode = "X";
            if (startRecord == false)
            {
                timerKeyCode.Enabled = true;
                startRecord = true;
                lblExStat.BackColor = Color.Red;
                lblExStat.Text = "recording";
                btnStartRecord.Text = "Stop Record";
                timerClickInterval.Enabled = true;
            }
            else
            {
                startRecord = false;
                lblExStat.BackColor = btnEmpty.BackColor;
                lblExStat.Text = "recording done";
                btnStartRecord.Text = "Start Record";
                dataGridActionList.Rows.RemoveAt(dataGridActionList.Rows.Count - 1);
                actionListID--;
                dataGridActionList.Rows.RemoveAt(dataGridActionList.Rows.Count - 1);
                actionListID--;
                timerClickInterval.Enabled = false;
            }
        }

        bool isRunningKeyboardRead = true;

        private void DAImageChecker_Load(object sender, EventArgs e)
        {

            Thread ThKeyboardRead = new Thread(KeyboardRead);
            ThKeyboardRead.SetApartmentState(ApartmentState.STA);
            //CheckForIllegalCrossThreadCalls = false;
            ThKeyboardRead.Start();
        }

        private void DAImageChecker_FormClosed(object sender, FormClosedEventArgs e)
        {
            isRunningKeyboardRead = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        int maxRepeats = 1;
        bool startPlay = false;
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (startPlay == false)
            {
                try { maxRepeats = Convert.ToInt32(txtRepeats.Text); }
                catch { MessageBox.Show("Put correct number for repeats"); }
                startPlay = true;
                lblExStat.BackColor = Color.Green;
                lblExStat.Text = "Play";
                btnPlay.Text = "Stop Play";
                if(checkBoxAwait.Checked == true)
                {
                    timerAwaitStartExecution.Enabled = true;
                }
                else
                {
                    timerActionExecute.Enabled = true;
                }
                
            }
            else
            {
                currentRepeat = 0;
                startPlay = false;
                lblExStat.BackColor = btnEmpty.BackColor;
                btnPlay.Text = "Start Play";
                lblExStat.Text = "execution stopped";
                timerActionExecute.Enabled = false;
            }
        }
        int currentActionID = 0;
        int clickInterval = 300;
        int mouseClickPosX = 0;
        int mouseClickPosY = 0;
        string currentActionCode = "X";
        Random rnd1 = new Random();
        int currentRepeat = 0;
        int imageNumber = 0;
        private void timerActionExecute_Tick(object sender, EventArgs e)
        {
            //listBox1.Items.Add(currentActionID + " ID");
            //int ID, int mSec, int posX, int posY, string action, string addedInfo
            if (dataGridActionList.RowCount >= 1 && currentRepeat < maxRepeats)
            {
                try
                {
                    clickInterval = Convert.ToInt32(dataGridActionList.Rows[currentActionID].Cells[1].Value);
                    mouseClickPosX = Convert.ToInt32(dataGridActionList.Rows[currentActionID].Cells[2].Value.ToString());
                    mouseClickPosY = Convert.ToInt32(dataGridActionList.Rows[currentActionID].Cells[3].Value.ToString());
                    currentActionCode = dataGridActionList.Rows[currentActionID].Cells[5].Value.ToString();
                    timerActionExecute.Interval = (clickInterval) + rnd1.Next(50);


                }
                catch
                {
                    timerActionExecute.Enabled = false;
                }
                switch (currentActionCode)
                {
                    case "MC1":
                        LeftClick(mouseClickPosX, mouseClickPosY);
                        break;
                    case "MC2":
                        RightClick(mouseClickPosX, mouseClickPosY);
                        break;
                    case "ALB":
                        MouseMoveTo(mouseClickPosX, mouseClickPosY);
                        break;
                    case "MM1":
                        MouseMoveTo(mouseClickPosX, mouseClickPosY);
                        break;
                    case "Pic":
                        imageNumber = Convert.ToInt32(dataGridActionList.Rows[currentActionID].Cells[7].Value.ToString());
                        failsCount = 0;
                        prufung = 0;
                        CreateScreenshot1(mouseClickPosX - 50, mouseClickPosY - 25);
                        secondImage = true;
                        quickSnapShot();
                        compareImages(imageNumber);
                        if (failsCount >= 60)
                        { currentActionID = currentActionID + 2; }
                        secondImage = false;
                        break;
                    default:
                        break;
                }
            }
            else { timerActionExecute.Enabled = false; }

            if (currentActionID < dataGridActionList.RowCount - 1)
            { currentActionID++; }
            else
            { currentActionID = 0; currentRepeat++; lblCurrentRepeat.Text = currentRepeat.ToString(); }

        }

        private void timerClickInterval_Tick(object sender, EventArgs e)
        {
            clickAwaitInterval++;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataGridActionList.DataSource = null;
            dataGridActionList.Rows.Clear();
            currentActionID = 0;
            actionListID = 0;
            currentRepeat = 0;
        }
        int failsCount = 0;
        int prufung = 0;

        private void compareImages(int imageNumber)
        {
            prufung = 0;
            failsCount = 0;
            for (int i = 30; i <= 69;)
            {
                for (int j = 2; j <= 48;)
                {
                    prufung++;
                    if (arFarben[i, j, 0, imageNumber] >= arFarben[i, j, 0, 105])
                    {
                        int ergebnis = arFarben[i, j, 1, imageNumber] - arFarben[i, j, 1, 105];
                        if (ergebnis > 50) { failsCount++; }
                    }
                    else
                    {
                        int ergebnis = arFarben[i, j, 1, 105] - arFarben[i, j, 1, imageNumber];
                        if (ergebnis > 50) { failsCount++; }
                    }

                    if (arFarben[i, j, 1, imageNumber] >= arFarben[i, j, 1, 105])
                    {
                        int ergebnis = arFarben[i, j, 2, imageNumber] - arFarben[i, j, 2, 105];
                        if (ergebnis > 50) { failsCount++; }
                    }
                    else
                    {
                        int ergebnis = arFarben[i, j, 2, 105] - arFarben[i, j, 2, imageNumber];
                        if (ergebnis > 50) { failsCount++; }
                    }
                    if (arFarben[i, j, 2, imageNumber] >= arFarben[i, j, 2, 105])
                    {
                        int ergebnis = arFarben[i, j, 3, imageNumber] - arFarben[i, j, 3, 105];
                        if (ergebnis > 50) { failsCount++; }
                    }
                    else
                    {
                        int ergebnis = arFarben[i, j, 3, 105] - arFarben[i, j, 3, imageNumber];
                        if (ergebnis > 50) { failsCount++; }
                    }
                    j = j + 2;
                }
                i = i + 2;
            }

        }

        private void showImage1(int imageNr)
        {
            Bitmap arrayToBmp = new Bitmap(100, 50);
            for (int i = 0; i <= 99;)
            {
                for (int j = 0; j <= 49;)
                {
                    arrayToBmp.SetPixel(i, j, Color.FromArgb(255, arFarben[i, j, 1, imageNr], arFarben[i, j, 2, imageNr], arFarben[i, j, 3, imageNr]));
                    j++;
                }
                i++;
            }
            picScreen1.Image = arrayToBmp;
        }
        private void showImage2(int imageNr)
        {
            Bitmap arrayToBmp = new Bitmap(100, 50);
            for (int i = 0; i <= 99;)
            {
                for (int j = 0; j <= 49;)
                {
                    arrayToBmp.SetPixel(i, j, Color.FromArgb(255, arFarben[i, j, 1, imageNr], arFarben[i, j, 2, imageNr], arFarben[i, j, 3, imageNr]));
                    j++;
                }
                i++;
            }
            picScreen3.Image = arrayToBmp;
        }
        private void btnFillArray_Click(object sender, EventArgs e)
        {
            label3.Text = failsCount.ToString();
            label4.Text = prufung.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nuAr = Convert.ToInt32(textBox1.Text);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int nuAr = Convert.ToInt32(textBox2.Text);

        }

        int awaitThreads = 0;
        private void timer4_Tick(object sender, EventArgs e)
        {
            awaitThreads++;
            if (awaitThreads >= 30)
            {
                awaitThreads = 0;
                btnStartRecord.Enabled = true;
                timer4.Enabled = false;
                startRecord = false;

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.Red;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.Green;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            button3.BackColor = btnEmpty.BackColor;
        }

        private void dataGridActionList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }
        private void dataGridActionList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string selectedActionCode = "X";
            int selectedImageID = 0;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridActionList.Rows[e.RowIndex];
                try
                {
                    selectedActionCode = row.Cells[5].Value.ToString();
                    selectedImageID = Convert.ToInt32(row.Cells[7].Value);
                    if (selectedActionCode == "Pic")
                    {
                        showImage1(selectedImageID);
                    }

                }
                catch { }
            }
            label1.Text = Convert.ToString(dataGridActionList.CurrentCell.Value);
        }
        int awaitTime = 0;
        private void timerAwaitStartExecution_Tick(object sender, EventArgs e)
        {
            if (awaitTime<=10)
            {
                awaitTime++;
            }
            else
            {
                timerActionExecute.Enabled = true;
                awaitTime = 0;
                timerAwaitStartExecution.Enabled = false;
            }
            
        }
    }
}
