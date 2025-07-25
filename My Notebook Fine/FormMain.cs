//System using.
using MyNotebook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

//Program namespace.
namespace Notebook
{
    //Main from.
    public partial class Notebook : Form
    {
        private string savepath = ""; //Initialize the savepath.

        public delegate void Settings(Control control, Color color);

        //Constructor function.
        public Notebook()
        {
            InitializeComponent(); //The code you must use to design the form,do not update it.
        }


        //-------------------------------------------------------
        //The code of ToolBar and Menu.
        //Software Status.
        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //Not use.
        }

        //Resave File in List.
        private void ���ΪAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Already used the click on Resavefile.
        }

        //Save File in List.
        private void ����SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (savepath != string.Empty)
            {
                txtMain.SaveFile(savepath, RichTextBoxStreamType.PlainText); //Save the file of PlainText on the path you choose.
                MessageBox.Show("�ļ��ɹ����浽·����" + savepath, "Result"); //Show the result of the saving.
                savepath = ""; //Reset the savepath.
            }
            else if (savepath == string.Empty)
            {
                MessageBox.Show("����ǰ��δ�򿪱����ļ������½�·�������棡", "Warning"); //Warning.
                SaveFileDialog saveFileDialog = new SaveFileDialog(); //Public a new class of SaveFileDialog.
                saveFileDialog.Title = "�Ƿ�Ҫ���浱ǰ�ļ���"; //Set the SaveFileDialog form's name.
                saveFileDialog.Filter = "�ı��ļ�|*.txt|DOC�ĵ�|*.doc|DOCX�ļ�|*.docx|HTM�ļ�|*.htm|HTML�ļ�|*.html|CSSԴ�ļ�|*.css|JavaScriptԴ�ļ�|*.js|C#Դ�ļ�|*.cs|C����Դ�ļ�|*.c|C++Դ�ļ�|*.cpp|JavaԴ�ļ�|*.java|PythonԴ�ļ�|*.py|R����Դ�ļ�|*.R|PHPԴ�ļ�|*.php|�����ļ�|*"; //Set the class of file which you can choose to save.
                if (saveFileDialog.ShowDialog() == DialogResult.OK) //Set a condition to determine if you click the botton of OK.
                {
                    //MessageBox.Show(openFileDialog.FileName);
                    string path = saveFileDialog.FileName; //Define the path of the file.
                    txtMain.SaveFile(path, RichTextBoxStreamType.PlainText); //Save the file of PlainText on the path you choose.
                    MessageBox.Show("�ļ��ɹ����浽·����" + path, "Result"); //Show the result of the saving.
                }
                else //Else condition.
                {
                    MessageBox.Show("���ѷ����Ե�ǰ�ļ��ı���!", "Warning"); //Show the result of the saving.
                }
            }
        }

        //Exit Software in List.
        private void �˳�XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Exit all the forms belong to the software.
        }

        //New File.
        private void newfile_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("ϵͳ��ʾ���Ƿ�Ҫ�½��ı�����������ǰ�༭���ļ��������ļ����½������ǣ����������沢�½������񣬷����½�����ȡ����رմ��ڡ�\nע�⣬�����ǰ�༭���ļ�Ϊ���ش��ļ���ֱ�ӱ��棬�Ǳ��ش��ļ�����Ҫ�½�·�������档", "Warning", MessageBoxButtons.YesNoCancel); //System prompt.
            if (dr == DialogResult.Yes) //Condition of OK.
            {
                if (savepath != string.Empty)
                {
                    txtMain.SaveFile(savepath, RichTextBoxStreamType.PlainText); //Save the file of PlainText on the path you choose.
                    MessageBox.Show("�ļ��ɹ����浽·����" + savepath, "Result"); //Show the result of the saving.
                    savepath = ""; //Reset the savepath.
                }
                else if (savepath == string.Empty)
                {
                    MessageBox.Show("����ǰ��δ�򿪱����ļ������½�·�������棡", "Warning"); //Warning.
                    SaveFileDialog saveFileDialog = new SaveFileDialog(); //Public a new class of SaveFileDialog.
                    saveFileDialog.Title = "�Ƿ�Ҫ���浱ǰ�ļ���"; //Set the SaveFileDialog form's name.
                    saveFileDialog.Filter = "�ı��ļ�|*.txt|DOC�ĵ�|*.doc|DOCX�ļ�|*.docx|HTM�ļ�|*.htm|HTML�ļ�|*.html|CSSԴ�ļ�|*.css|JavaScriptԴ�ļ�|*.js|C#Դ�ļ�|*.cs|C����Դ�ļ�|*.c|C++Դ�ļ�|*.cpp|JavaԴ�ļ�|*.java|PythonԴ�ļ�|*.py|R����Դ�ļ�|*.R|PHPԴ�ļ�|*.php|�����ļ�|*"; //Set the class of file which you can choose to save.
                    if (saveFileDialog.ShowDialog() == DialogResult.OK) //Set a condition to determine if you click the botton of OK.
                    {
                        //MessageBox.Show(openFileDialog.FileName);
                        string path = saveFileDialog.FileName; //Define the path of the file.
                        txtMain.SaveFile(path, RichTextBoxStreamType.PlainText); //Save the file of PlainText on the path you choose.
                        MessageBox.Show("�ļ��ɹ����浽·����" + path, "Result"); //Show the result of the saving.
                    }
                    else //Else condition.
                    {
                        MessageBox.Show("���ѷ����Ե�ǰ�ļ��ı���!", "Warning"); //Show the result of the saving.
                    }
                }
                txtMain.Clear(); //Remove the text in the txtMain Container.
            }
            else if (dr == DialogResult.No) //Condition of No.
            {
                MessageBox.Show("���ѷ����Ե�ǰ�ļ��ı���!", "Warning"); //Show the result of the saving.
                txtMain.Clear(); //Remove the text in the txtMain Container.
            }
            else if (dr == DialogResult.Cancel) //Condition of Cancel.
            {
                //Do nothing.
            }
        }

        //Tool Box.
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //No use.
        }

        //New File in List.
        private void �½�NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("ϵͳ��ʾ���Ƿ�Ҫ�½��ı�����������ǰ�༭���ļ��������ļ����½������ǣ����������沢�½������񣬷����½�����ȡ����رմ��ڡ�\nע�⣬�����ǰ�༭���ļ�Ϊ���ش��ļ���ֱ�ӱ��棬�Ǳ��ش��ļ�����Ҫ�½�·�������档", "Warning", MessageBoxButtons.YesNoCancel); //System prompt.
            if (dr == DialogResult.Yes) //Condition of OK.
            {
                if (savepath != string.Empty)
                {
                    txtMain.SaveFile(savepath, RichTextBoxStreamType.PlainText); //Save the file of PlainText on the path you choose.
                    MessageBox.Show("�ļ��ɹ����浽·����" + savepath, "Result"); //Show the result of the saving.
                    savepath = ""; //Reset the savepath.
                }
                else if (savepath == string.Empty)
                {
                    MessageBox.Show("����ǰ��δ�򿪱����ļ������½�·�������棡", "Warning"); //Warning.
                    SaveFileDialog saveFileDialog = new SaveFileDialog(); //Public a new class of SaveFileDialog.
                    saveFileDialog.Title = "�Ƿ�Ҫ���浱ǰ�ļ���"; //Set the SaveFileDialog form's name.
                    saveFileDialog.Filter = "�ı��ļ�|*.txt|DOC�ĵ�|*.doc|DOCX�ļ�|*.docx|HTM�ļ�|*.htm|HTML�ļ�|*.html|CSSԴ�ļ�|*.css|JavaScriptԴ�ļ�|*.js|C#Դ�ļ�|*.cs|C����Դ�ļ�|*.c|C++Դ�ļ�|*.cpp|JavaԴ�ļ�|*.java|PythonԴ�ļ�|*.py|R����Դ�ļ�|*.R|PHPԴ�ļ�|*.php|�����ļ�|*"; //Set the class of file which you can choose to save.
                    if (saveFileDialog.ShowDialog() == DialogResult.OK) //Set a condition to determine if you click the botton of OK.
                    {
                        //MessageBox.Show(openFileDialog.FileName);
                        string path = saveFileDialog.FileName; //Define the path of the file.
                        txtMain.SaveFile(path, RichTextBoxStreamType.PlainText); //Save the file of PlainText on the path you choose.
                        MessageBox.Show("�ļ��ɹ����浽·����" + path, "Result"); //Show the result of the saving.
                    }
                    else //Else condition.
                    {
                        MessageBox.Show("���ѷ����Ե�ǰ�ļ��ı���!", "Warning"); //Show the result of the saving.
                    }
                }
                txtMain.Clear(); //Remove the text in the txtMain Container.
            }
            else if (dr == DialogResult.No) //Condition of No.
            {
                MessageBox.Show("���ѷ����Ե�ǰ�ļ��ı���!", "Warning"); //Show the result of the saving.
                txtMain.Clear(); //Remove the text in the txtMain Container.
            }
            else if (dr == DialogResult.Cancel) //Condition of Cancel.
            {
                //Do nothing.
            }
        }

        //Left justifying.
        private void �����toolStripButton_Click(object sender, EventArgs e)
        {
            txtMain.SelectionAlignment = HorizontalAlignment.Left; //Let the selection alignment to be left.
        }

        //Right justifying.
        private void �Ҷ���toolStripButton_Click(object sender, EventArgs e)
        {
            txtMain.SelectionAlignment = HorizontalAlignment.Right; //Let the selection alignment to be right.
        }

        //Center aligned.
        private void ����toolStripButton_Click(object sender, EventArgs e)
        {
            txtMain.SelectionAlignment = HorizontalAlignment.Center; //Let the selection alignment to be center.
        }

        //Text indent.
        private void ��������toolStripButton_Click(object sender, EventArgs e)
        {
            int textIndent = 30 * Convert.ToInt16(toolStripTextBox5.Text); //Get the string you input in the textbox and convert it to int and multiply 30.
            txtMain.SelectionIndent = textIndent; //Set the text selection indent.
            txtMain.SelectionHangingIndent = textIndent - 2 * textIndent; //Let the line under the indent line do not move.
        }

        //Text indent in menu.
        private void ���������ַ�toolStripMenuItem_Click(object sender, EventArgs e)
        {
            int textIndent = 30 * Convert.ToInt16(toolStripTextBox4.Text); //Get the string you input in the textbox and convert it to int and multiply 30.
            txtMain.SelectionIndent = textIndent; //Set the text selection indent.
            txtMain.SelectionHangingIndent = textIndent - 2 * textIndent; //Let the line under the indent line do not move.
        }

        //Generation log.
        private void ������־toolStripButton_Click(object sender, EventArgs e)
        {
            int EditorWidth = txtMain.Width / 15; //Get the width of editor.
            string time = System.DateTime.Now.ToString(); //Define the time and use the system time.
            string DevideLine = new string('��', EditorWidth); //Set a string of '-' and use the width to calculate the length of the string.
            if (txtMain.Text == string.Empty) //Condition of editor is empty.
            {
                txtMain.AppendText(DevideLine); //Add the time now after the text it already exit.
                txtMain.AppendText("\n"); //Wrap.
                txtMain.AppendText("ʱ�䣺" + time + "         �ص㣺" + "         ������" + "         ���飺"); //Add the time now after the text it already exit.
                txtMain.AppendText("\n"); //Wrap.
                txtMain.AppendText("\n"); //Wrap.
                txtMain.AppendText("\n"); //Wrap.
                txtMain.AppendText("\n"); //Wrap.
                txtMain.AppendText("\n"); //Wrap.
                txtMain.AppendText("\n"); //Wrap.
                txtMain.AppendText("\n"); //Wrap.
                txtMain.AppendText("\n"); //Wrap.
                txtMain.AppendText("\n"); //Wrap.
                txtMain.AppendText("\n"); //Wrap.
                txtMain.AppendText("\n"); //Wrap.
                txtMain.AppendText("\n"); //Wrap.
                txtMain.AppendText("\n"); //Wrap.
                txtMain.AppendText("\n"); //Wrap.
                txtMain.AppendText("\n"); //Wrap.
                txtMain.AppendText(DevideLine); //Add the time now after the text it already exit.
            }
            else
            {
                txtMain.AppendText("\n"); //Wrap.
                txtMain.AppendText(DevideLine); //Add the time now after the text it already exit.
                txtMain.AppendText("\n"); //Wrap.
                txtMain.AppendText("ʱ�䣺" + time + "         �ص㣺" + "         ������" + "         ���飺"); //Add the time now after the text it already exit.
                txtMain.AppendText("\n"); //Wrap.
                txtMain.AppendText("\n"); //Wrap.
                txtMain.AppendText("\n"); //Wrap.
                txtMain.AppendText("\n"); //Wrap.
                txtMain.AppendText("\n"); //Wrap.
                txtMain.AppendText("\n"); //Wrap.
                txtMain.AppendText("\n"); //Wrap.
                txtMain.AppendText("\n"); //Wrap.
                txtMain.AppendText("\n"); //Wrap.
                txtMain.AppendText("\n"); //Wrap.
                txtMain.AppendText("\n"); //Wrap.
                txtMain.AppendText("\n"); //Wrap.
                txtMain.AppendText("\n"); //Wrap.
                txtMain.AppendText("\n"); //Wrap.
                txtMain.AppendText("\n"); //Wrap.
                txtMain.AppendText(DevideLine); //Add the time now after the text it already exit.
            }
        }

        //Timer server.
        private void ServerStart(object sender, ElapsedEventArgs e)
        {
            txtMain.SaveFile(savepath, RichTextBoxStreamType.PlainText); //Save the file of PlainText on the path you choose.
        }

        //Save file follow the time.
        private void ʵʱ����toolStripMenuItem_Click(object sender, EventArgs e)
        {
            ʵʱ����toolStripMenuItem.Checked = !ʵʱ����toolStripMenuItem.Checked; //Reverse selection.
            if (ʵʱ����toolStripMenuItem.Checked == true) //Condition.
            {
                if (savepath != string.Empty)
                {
                    System.Timers.Timer t = new System.Timers.Timer(500); //Public the class of time and set the time interval of 0.5s.
                    t.Elapsed += new System.Timers.ElapsedEventHandler(ServerStart); //Do the void ServerStart since the time arriving.
                    t.AutoReset = true; //Set it always do the true.
                    t.Enabled = true; //Set it always do the System.Timers.Timer.Elapsed.
                    t.Start(); //Start the timer.
                }
                else if (savepath == string.Empty)
                {
                    MessageBox.Show("����ǰ��δ�򿪱����ļ����뱣�浽���������´��ļ���", "Warning"); //Warning.
                }
            }
            else if(ʵʱ����toolStripMenuItem.Checked == false)
            {
                //Do nothing.
            }
        }

        //Regular.
        private void ��ԭtoolStripButton_Click(object sender, EventArgs e)
        {
            Font Oldfont = txtMain.SelectionFont; //Get the font of the select text.
            txtMain.SelectionFont = new Font(Oldfont, FontStyle.Regular); //Reset the fontstyle.
        }

        //Bold.
        private void �Ӵ�toolStripButton_Click(object sender, EventArgs e)
        {
            Font Oldfont = txtMain.SelectionFont; //Get the font of the select text.
            txtMain.SelectionFont = new Font(Oldfont, FontStyle.Bold); //Reset the fontstyle.
        }

        //Italic.
        private void б��toolStripButton_Click(object sender, EventArgs e)
        {
            Font Oldfont = txtMain.SelectionFont; //Get the font of the select text.
            txtMain.SelectionFont = new Font(Oldfont, FontStyle.Italic); //Reset the fontstyle.
        }

        //Underline.
        private void �»���toolStripButton_Click(object sender, EventArgs e)
        {
            Font Oldfont = txtMain.SelectionFont; //Get the font of the select text.
            txtMain.SelectionFont = new Font(Oldfont, FontStyle.Underline); //Reset the fontstyle.
        }

        //Strikeout.
        private void ɾ����toolStripButton_Click(object sender, EventArgs e)
        {
            Font Oldfont = txtMain.SelectionFont; //Get the font of the select text.
            txtMain.SelectionFont = new Font(Oldfont, FontStyle.Strikeout); //Reset the fontstyle.
        }

        //Welcome.
        private void ��ӭtoolStripButton_Click(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome(); //Public a class called welcome.
            welcome.ShowInTaskbar = false; //Let this form not show in the taskbar.
            welcome.ShowDialog(); //Show the form.
        }

        //About in List.
        private void ����AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout FormAbout = new FormAbout(); //Public the class calls FormAbout.
            FormAbout.ShowInTaskbar = false; //Let it can not be showed in the System Taskbar.
            FormAbout.ShowDialog(); //Let this botton link to the FormAbout and can not be covered if you do not close it.
        }

        //Search.
        private void ����toolStripButton_Click(object sender, EventArgs e)
        {
            string searchText = toolStripTextBox1.Text; //Define a string data called searchText to read the text of SearchTextBox.
            txtMain.Focus();
            txtMain.Find(searchText); //Use the system function called Find on the editor to locate the text you want.
        }

        //Amplify the fontsize.
        private void �Ŵ�toolStripButton_Click(object sender, EventArgs e)
        {
            string fontstyle = txtMain.Font.Name; //Get the fontstyle of the editor. 
            float fontsize = txtMain.Font.Size; //Get the fontsize of the editor.
            fontsize = fontsize + 1; //Add 1 to fontsize.
            Font font = new Font(fontstyle, fontsize); //Define a new font of the editor.
            txtMain.Font = font; //Use the font.
        }

        //Reduce the fontsize.
        private void ��СtoolStripButton_Click(object sender, EventArgs e)
        {
            string fontstyle = txtMain.Font.Name; //Get the fontstyle of the editor. 
            float fontsize = txtMain.Font.Size; //Get the fontsize of the editor.
            fontsize = fontsize - 1; //Delete 1 to fontsize.
            Font font = new Font(fontstyle, fontsize); //Define a new font of the editor.
            txtMain.Font = font; //Use the font.
        }

        //Add the time now in the editor.
        private void ��ǰʱ��toolStripButton_Click(object sender, EventArgs e)
        {
            string time = System.DateTime.Now.ToString(); //Define the time and use the system time.
            if (txtMain.Text == string.Empty) //Condition of editor is empty.
            {
                txtMain.AppendText(time); //Add the time now after the text it already exit.
                txtMain.AppendText("\n"); //Wrap.
            }
            else 
            {
                txtMain.AppendText("\n"); //Wrap.
                txtMain.AppendText(time); //Add the time now after the text it already exit.
                txtMain.AppendText("\n"); //Wrap.
            }
        }

        //Software Introduction and Help.
        private void help_Click(object sender, EventArgs e)
        {
            Software_Introduction softwareIntroduction = new Software_Introduction(); //Public the class calls Software_Introduction.
            softwareIntroduction.ShowInTaskbar = false; //Let it can not be showed in the System Taskbar.
            softwareIntroduction.ShowDialog(); //Let this botton link to the Software_Introduction and can not be covered if you do not close it.
        }

        //Update logs.
        private void ������־toolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update_Logs updateLogs = new Update_Logs(); //Public the class calls Update_Logs.
            updateLogs.ShowInTaskbar = false; //Let it can not be showed in the System Taskbar.
            updateLogs.ShowDialog(); //Let this botton link to the Update_Logs and can not be covered if you do not close it.
        }

        //Openfile.
        private void openfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog(); //Public a new class of OpenFileDialog.
            openFileDialog.Title = "���ļ�"; //Set the OpenFileDialog form's name.
            openFileDialog.Filter = "�ı��ļ�|*.txt|DOC�ĵ�|*.doc|DOCX�ļ�|*.docx|HTM�ļ�|*.htm|HTML�ļ�|*.html|CSSԴ�ļ�|*.css|JavaScriptԴ�ļ�|*.js|C#Դ�ļ�|*.cs|C����Դ�ļ�|*.c|C++Դ�ļ�|*.cpp|JavaԴ�ļ�|*.java|PythonԴ�ļ�|*.py|R����Դ�ļ�|*.R|PHPԴ�ļ�|*.php|�����ļ�|*"; //Set the class of file which you can choose to open. 
            if (openFileDialog.ShowDialog()==DialogResult.OK) //Set a condition to determine if you click the botton of OK.
            {
                //MessageBox.Show(openFileDialog.FileName);
                savepath = openFileDialog.FileName;
                txtMain.LoadFile(savepath, RichTextBoxStreamType.PlainText); //Let the file you choose display in the richTextBox calls txtMain.
                //This system method needs both the path of the file which you open and the class of the file you want to display in the container. 
            }
        }

        //Openfile in List.
        private void ��OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog(); //Public a new class of OpenFileDialog.
            openFileDialog.Title = "���ļ�"; //Set the OpenFileDialog form's name.
            openFileDialog.Filter = "�ı��ļ�|*.txt|DOC�ĵ�|*.doc|DOCX�ļ�|*.docx|HTM�ļ�|*.htm|HTML�ļ�|*.html|CSSԴ�ļ�|*.css|JavaScriptԴ�ļ�|*.js|C#Դ�ļ�|*.cs|C����Դ�ļ�|*.c|C++Դ�ļ�|*.cpp|JavaԴ�ļ�|*.java|PythonԴ�ļ�|*.py|R����Դ�ļ�|*.R|PHPԴ�ļ�|*.php|�����ļ�|*"; //Set the class of file which you can choose to open. 
            if (openFileDialog.ShowDialog() == DialogResult.OK) //Set a condition to determine if you click the botton of OK.
            {
                //MessageBox.Show(openFileDialog.FileName);
                savepath = openFileDialog.FileName; //Define the path of the file.
                txtMain.LoadFile(savepath, RichTextBoxStreamType.PlainText); //Let the file you choose display in the richTextBox calls txtMain.
                //This system method needs both the path of the file which you open and the class of the file you want to display in the container. 
            }
        }

        //Savefile.
        private void savefile_Click(object sender, EventArgs e)
        {
            if (savepath != string.Empty)
            {
                txtMain.SaveFile(savepath, RichTextBoxStreamType.PlainText); //Save the file of PlainText on the path you choose.
                MessageBox.Show("�ļ��ɹ����浽·����" + savepath, "Result"); //Show the result of the saving.
                savepath = ""; //Reset the savepath.
            }
            else if (savepath == string.Empty)
            {
                MessageBox.Show("����ǰ��δ�򿪱����ļ������½�·�������棡", "Warning"); //Warning.
                SaveFileDialog saveFileDialog = new SaveFileDialog(); //Public a new class of SaveFileDialog.
                saveFileDialog.Title = "�Ƿ�Ҫ���浱ǰ�ļ���"; //Set the SaveFileDialog form's name.
                saveFileDialog.Filter = "�ı��ļ�|*.txt|DOC�ĵ�|*.doc|DOCX�ļ�|*.docx|HTM�ļ�|*.htm|HTML�ļ�|*.html|CSSԴ�ļ�|*.css|JavaScriptԴ�ļ�|*.js|C#Դ�ļ�|*.cs|C����Դ�ļ�|*.c|C++Դ�ļ�|*.cpp|JavaԴ�ļ�|*.java|PythonԴ�ļ�|*.py|R����Դ�ļ�|*.R|PHPԴ�ļ�|*.php|�����ļ�|*"; //Set the class of file which you can choose to save.
                if (saveFileDialog.ShowDialog() == DialogResult.OK) //Set a condition to determine if you click the botton of OK.
                {
                    //MessageBox.Show(openFileDialog.FileName);
                    string path = saveFileDialog.FileName; //Define the path of the file.
                    txtMain.SaveFile(path, RichTextBoxStreamType.PlainText); //Save the file of PlainText on the path you choose.
                    MessageBox.Show("�ļ��ɹ����浽·����" + path, "Result"); //Show the result of the saving.
                }
                else //Else condition.
                {
                    MessageBox.Show("���ѷ����Ե�ǰ�ļ��ı���!", "Warning"); //Show the result of the saving.
                }
            }
        }

        //Resavefile.
        private void resavefile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog(); //Public a new class of SaveFileDialog.
            saveFileDialog.Title = "���Ϊ�ļ�"; //Set the SaveFileDialog form's name.
            saveFileDialog.Filter = "�ı��ļ�|*.txt|DOC�ĵ�|*.doc|DOCX�ļ�|*.docx|HTM�ļ�|*.htm|HTML�ļ�|*.html|CSSԴ�ļ�|*.css|JavaScriptԴ�ļ�|*.js|C#Դ�ļ�|*.cs|C����Դ�ļ�|*.c|C++Դ�ļ�|*.cpp|JavaԴ�ļ�|*.java|PythonԴ�ļ�|*.py|R����Դ�ļ�|*.R|PHPԴ�ļ�|*.php|�����ļ�|*"; //Set the class of file which you can choose to resave.
            if (saveFileDialog.ShowDialog() == DialogResult.OK) //Set a condition to determine if you click the botton of OK.
            {
                //MessageBox.Show(openFileDialog.FileName);
                string path = saveFileDialog.FileName; //Define the path of the file.
                txtMain.SaveFile(path, RichTextBoxStreamType.PlainText); //Save the file of PlainText on the path you choose.
                MessageBox.Show("�ļ��ɹ����浽·����" + path, "Result"); //Show the result of the saving.
            }
        }

        //Fontset.
        private void Fontset_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog(); //Public a new class of FontDialog.
            fontDialog.ShowColor = true; //Let the fontdialog can show color choose.
            fontDialog.Font = txtMain.SelectionFont; //Set the showed font of Fontdialog.
            fontDialog.Color = txtMain.SelectionColor; //Set the showed color of Fontdialog.
            if (fontDialog.ShowDialog() == DialogResult.OK) //Set a condition to determine if you click the button of OK.
            {
                Font font = fontDialog.Font; //Public a new class of font.
                txtMain.SelectionFont = font; //Let the selected text use the font you choose.
                Color color=fontDialog.Color; //Public a new class of color.
                txtMain.SelectionColor = color; //Let the selected text use the color you choose.
            }
        }

        //Print preview.
        private void printpreview_Click(object sender, EventArgs e)
        {
            //PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog(); //Public a new class of PrintPreviewDialog.
            printPreviewDialog.Document = printDocument; //Set the printDocument.
            printPreviewDialog.ShowDialog(); //Show the form of printPreviewDialog.
        }

        //Print.
        private void printfile_Click(object sender, EventArgs e)
        {
            //PrintDialog printDialog = new PrintDialog(); //Public a new class of PrintDialog.
            printDialog.Document = printDocument; //Set the printDocument.
            printDialog.ShowDialog(); //Show the form of printDialog.
        }

        //Undo.
        private void undo_Click(object sender, EventArgs e)
        {
            txtMain.Undo(); //Undo the thing you do on the editor.
        }

        //Exchange text.
        private void �滻toolStripButton_Click(object sender, EventArgs e)
        {
            txtMain.SelectedText = toolStripTextBox2.Text; //Let the text selected in the editor exchanged to the text you input in the toolstriptextbox2.
        }

        //Redo.
        private void redo_Click(object sender, EventArgs e)
        {
            txtMain.Redo(); //Redo the thing you do on the editor.
        }

        //Cut.
        private void cut_Click(object sender, EventArgs e)
        {
            txtMain.Cut(); //Cut the text you select on the editor.
        }

        //Copy.
        private void copy_Click(object sender, EventArgs e)
        {
            txtMain.Copy(); //Copy the text you select on the editor.
        }

        //Paste.
        private void paste_Click(object sender, EventArgs e)
        {
            txtMain.Paste(); //Paste the text you select on the editor.
        }

        //Select all.
        private void selectall_Click(object sender, EventArgs e)
        {
            txtMain.SelectAll(); //Select all the on the editor.
        }

        //Exit software.
        private void exitsoftware_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Exit all the forms belong to the software.
        }

        //Theme White in menu.
        private void ����toolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Conditions to determine if the botton is checked.
            ����toolStripMenuItem.Checked = !����toolStripMenuItem.Checked; //Reverse selection.

            //Conditions to change the theme.
            if (����toolStripMenuItem.Checked == true)
            {
                menuStrip1.BackColor = Color.DeepSkyBlue; //Set the backcolor of menuStrip1.
                statusStrip1.BackColor = Color.DeepSkyBlue; //Set the backcolor of statusStrip1.
                menuStrip1.ForeColor = Color.White; //Set the forecolor of menuStrip1.
                statusStrip1.ForeColor = Color.White; //Set the forecolor of statusStrip1.
                toolStrip1.BackColor = Color.AliceBlue; //Set the backColor of toolStrip1.
                toolStrip1.ForeColor = Color.Black; //Set the forecolor of toolStrip1.
                txtMain.BackColor = Color.White; //Set the backcolor of editor.
                txtMain.ForeColor = Color.Black; //Set the forecolor of editor.

                //Unchecked other items.
                ��ҹtoolStripMenuItem.Checked = false;
                ʦ����toolStripMenuItem.Checked = false;
            }
            if (����toolStripMenuItem.Checked == false)
            {
                menuStrip1.BackColor = Color.Thistle; //Set the backcolor of menuStrip1.
                statusStrip1.BackColor = Color.Thistle; //Set the backcolor of statusStrip1.
                menuStrip1.ForeColor = Color.Black; //Set the forecolor of menuStrip1.
                statusStrip1.ForeColor = Color.Black; //Set the forecolor of statusStrip1.
                toolStrip1.BackColor = Color.LavenderBlush; //Set the backColor of toolStrip1.
                toolStrip1.ForeColor = Color.Black; //Set the forecolor of toolStrip1.
                txtMain.BackColor = Color.White; //Set the backcolor of editor.
                txtMain.ForeColor = Color.Black; //Set the forecolor of editor.
            }
        }

        //Theme Black in menu.
        private void ��ҹtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Conditions to determine if the botton is checked.
            ��ҹtoolStripMenuItem.Checked = !��ҹtoolStripMenuItem.Checked; //Reverse selection.

            //Conditions to change the theme.
            if (��ҹtoolStripMenuItem.Checked == true)
            {
                menuStrip1.BackColor = Color.Black; //Set the backcolor of menuStrip1.
                statusStrip1.BackColor = Color.Black; //Set the backcolor of statusStrip1.
                menuStrip1.ForeColor = Color.White; //Set the forecolor of menuStrip1.
                statusStrip1.ForeColor = Color.White; //Set the forecolor of statusStrip1.
                toolStrip1.BackColor = Color.Gainsboro; //Set the backColor of toolStrip1.
                toolStrip1.ForeColor = Color.Black; //Set the forecolor of toolStrip1.
                txtMain.BackColor = Color.White; //Set the backcolor of editor.
                txtMain.ForeColor = Color.Black; //Set the forecolor of editor.

                //Unchecked other items.
                ����toolStripMenuItem.Checked = false;
                ʦ����toolStripMenuItem.Checked = false;
            }
            if (��ҹtoolStripMenuItem.Checked == false)
            {
                menuStrip1.BackColor = Color.Thistle; //Set the backcolor of menuStrip1.
                statusStrip1.BackColor = Color.Thistle; //Set the backcolor of statusStrip1.
                menuStrip1.ForeColor = Color.Black; //Set the forecolor of menuStrip1.
                statusStrip1.ForeColor = Color.Black; //Set the forecolor of statusStrip1.
                toolStrip1.BackColor = Color.LavenderBlush; //Set the backColor of toolStrip1.
                toolStrip1.ForeColor = Color.Black; //Set the forecolor of toolStrip1.
                txtMain.BackColor = Color.White; //Set the backcolor of editor.
                txtMain.ForeColor = Color.Black; //Set the forecolor of editor.
            }
        }

        //Theme Pink in menu.
        private void ʦ����toolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Conditions to determine if the botton is checked.
            ʦ����toolStripMenuItem.Checked = !ʦ����toolStripMenuItem.Checked; //Reverse selection.

            //Conditions to change the theme.
            if (ʦ����toolStripMenuItem.Checked == true)
            {
                menuStrip1.BackColor = Color.Thistle; //Set the backcolor of menuStrip1.
                statusStrip1.BackColor = Color.Thistle; //Set the backcolor of statusStrip1.
                menuStrip1.ForeColor = Color.Black; //Set the forecolor of menuStrip1.
                statusStrip1.ForeColor = Color.Black; //Set the forecolor of statusStrip1.
                toolStrip1.BackColor = Color.LavenderBlush; //Set the backColor of toolStrip1.
                toolStrip1.ForeColor = Color.Black; //Set the forecolor of toolStrip1.
                txtMain.BackColor = Color.White; //Set the backcolor of editor.
                txtMain.ForeColor = Color.Black; //Set the forecolor of editor.

                //Unchecked other items.
                ����toolStripMenuItem.Checked = false;
                ��ҹtoolStripMenuItem.Checked = false;
            }
            if (ʦ����toolStripMenuItem.Checked == false)
            {
                menuStrip1.BackColor = Color.Thistle; //Set the backcolor of menuStrip1.
                statusStrip1.BackColor = Color.Thistle; //Set the backcolor of statusStrip1.
                menuStrip1.ForeColor = Color.Black; //Set the forecolor of menuStrip1.
                statusStrip1.ForeColor = Color.Black; //Set the forecolor of statusStrip1.
                toolStrip1.BackColor = Color.LavenderBlush; //Set the backColor of toolStrip1.
                toolStrip1.ForeColor = Color.Black; //Set the forecolor of toolStrip1.
                txtMain.BackColor = Color.White; //Set the backcolor of editor.
                txtMain.ForeColor = Color.Black; //Set the forecolor of editor.
            }
        }

        //Theme White.
        private void WhitetoolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Conditions to determine if the botton is checked.
            WhitetoolStripMenuItem.Checked = !WhitetoolStripMenuItem.Checked; //Reverse selection.

            //Conditions to change the theme.
            if (WhitetoolStripMenuItem.Checked == true)
            {
                menuStrip1.BackColor = Color.DeepSkyBlue; //Set the backcolor of menuStrip1.
                statusStrip1.BackColor = Color.DeepSkyBlue; //Set the backcolor of statusStrip1.
                menuStrip1.ForeColor = Color.White; //Set the forecolor of menuStrip1.
                statusStrip1.ForeColor = Color.White; //Set the forecolor of statusStrip1.
                toolStrip1.BackColor = Color.AliceBlue; //Set the backColor of toolStrip1.
                toolStrip1.ForeColor = Color.Black; //Set the forecolor of toolStrip1.
                txtMain.BackColor = Color.White; //Set the backcolor of editor.
                txtMain.ForeColor = Color.Black; //Set the forecolor of editor.

                //Unchecked other items.
                BlacktoolStripMenuItem.Checked = false;
                PinkStripMenuItem.Checked = false;
            }
            if (WhitetoolStripMenuItem.Checked == false)
            {
                menuStrip1.BackColor = Color.Thistle; //Set the backcolor of menuStrip1.
                statusStrip1.BackColor = Color.Thistle; //Set the backcolor of statusStrip1.
                menuStrip1.ForeColor = Color.Black; //Set the forecolor of menuStrip1.
                statusStrip1.ForeColor = Color.Black; //Set the forecolor of statusStrip1.
                toolStrip1.BackColor = Color.LavenderBlush; //Set the backColor of toolStrip1.
                toolStrip1.ForeColor = Color.Black; //Set the forecolor of toolStrip1.
                txtMain.BackColor = Color.White; //Set the backcolor of editor.
                txtMain.ForeColor = Color.Black; //Set the forecolor of editor.
            }
        }

        //Theme Black.
        private void BlacktoolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Conditions to determine if the botton is checked.
            BlacktoolStripMenuItem.Checked = !BlacktoolStripMenuItem.Checked; //Reverse selection.

            //Conditions to change the theme.
            if (BlacktoolStripMenuItem.Checked == true)
            {
                menuStrip1.BackColor = Color.Black; //Set the backcolor of menuStrip1.
                statusStrip1.BackColor = Color.Black; //Set the backcolor of statusStrip1.
                menuStrip1.ForeColor = Color.White; //Set the forecolor of menuStrip1.
                statusStrip1.ForeColor = Color.White; //Set the forecolor of statusStrip1.
                toolStrip1.BackColor = Color.Gainsboro; //Set the backColor of toolStrip1.
                toolStrip1.ForeColor = Color.Black; //Set the forecolor of toolStrip1.
                txtMain.BackColor = Color.White; //Set the backcolor of editor.
                txtMain.ForeColor = Color.Black; //Set the forecolor of editor.

                //Unchecked other items.
                WhitetoolStripMenuItem.Checked = false;
                PinkStripMenuItem.Checked = false;
            }
            if (BlacktoolStripMenuItem.Checked == false)
            {
                menuStrip1.BackColor = Color.Thistle; //Set the backcolor of menuStrip1.
                statusStrip1.BackColor = Color.Thistle; //Set the backcolor of statusStrip1.
                menuStrip1.ForeColor = Color.Black; //Set the forecolor of menuStrip1.
                statusStrip1.ForeColor = Color.Black; //Set the forecolor of statusStrip1.
                toolStrip1.BackColor = Color.LavenderBlush; //Set the backColor of toolStrip1.
                toolStrip1.ForeColor = Color.Black; //Set the forecolor of toolStrip1.
                txtMain.BackColor = Color.White; //Set the backcolor of editor.
                txtMain.ForeColor = Color.Black; //Set the forecolor of editor.
            }
        }

        //Theme Pink.
        private void PinkStripMenuItem_Click(object sender, EventArgs e)
        {
            //Conditions to determine if the botton is checked.
            PinkStripMenuItem.Checked = !PinkStripMenuItem.Checked; //Reverse selection.

            //Conditions to change the theme.
            if (PinkStripMenuItem.Checked == true)
            {
                menuStrip1.BackColor = Color.Thistle; //Set the backcolor of menuStrip1.
                statusStrip1.BackColor = Color.Thistle; //Set the backcolor of statusStrip1.
                menuStrip1.ForeColor = Color.Black; //Set the forecolor of menuStrip1.
                statusStrip1.ForeColor = Color.Black; //Set the forecolor of statusStrip1.
                toolStrip1.BackColor = Color.LavenderBlush; //Set the backColor of toolStrip1.
                toolStrip1.ForeColor = Color.Black; //Set the forecolor of toolStrip1.
                txtMain.BackColor = Color.White; //Set the backcolor of editor.
                txtMain.ForeColor = Color.Black; //Set the forecolor of editor.

                //Unchecked other items.
                WhitetoolStripMenuItem.Checked = false;
                BlacktoolStripMenuItem.Checked = false;
            }
            if (PinkStripMenuItem.Checked == false)
            {
                menuStrip1.BackColor = Color.Thistle; //Set the backcolor of menuStrip1.
                statusStrip1.BackColor = Color.Thistle; //Set the backcolor of statusStrip1.
                menuStrip1.ForeColor = Color.Black; //Set the forecolor of menuStrip1.
                statusStrip1.ForeColor = Color.Black; //Set the forecolor of statusStrip1.
                toolStrip1.BackColor = Color.LavenderBlush; //Set the backColor of toolStrip1.
                toolStrip1.ForeColor = Color.Black; //Set the forecolor of toolStrip1.
                txtMain.BackColor = Color.White; //Set the backcolor of editor.
                txtMain.ForeColor = Color.Black; //Set the forecolor of editor.
            }
        }

        //Background color black.
        private void ����ɫtoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Conditions to determine if the botton is checked.
            ����ɫtoolStripMenuItem1.Checked = !����ɫtoolStripMenuItem1.Checked; //Reverse selection.

            //Conditions to change.
            if (����ɫtoolStripMenuItem1.Checked == true)
            {
                txtMain.BackColor = Color.Black; //Set the backcolor of editor.
                txtMain.ForeColor = Color.White; //Set the backcolor of editor.

                //Unchecked other items.
                ����ɫtoolStripMenuItem2.Checked = false;
                ����ɫtoolStripMenuItem3.Checked = false;
            }
            if (����ɫtoolStripMenuItem1.Checked == false)
            {
                txtMain.BackColor = Color.White; //Set the backcolor of editor.
                txtMain.ForeColor = Color.Black; //Set the backcolor of editor.
            }
        }

        //Background color white.
        private void ����ɫtoolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //Conditions to determine if the botton is checked.
            ����ɫtoolStripMenuItem2.Checked = !����ɫtoolStripMenuItem2.Checked; //Reverse selection.

            //Conditions to change.
            if (����ɫtoolStripMenuItem2.Checked == true)
            {
                txtMain.BackColor = Color.White; //Set the backcolor of editor.
                txtMain.ForeColor = Color.Black; //Set the backcolor of editor.

                //Unchecked other items.
                ����ɫtoolStripMenuItem1.Checked = false;
                ����ɫtoolStripMenuItem3.Checked = false;
            }
            if (����ɫtoolStripMenuItem2.Checked == false)
            {
                txtMain.BackColor = Color.White; //Set the backcolor of editor.
                txtMain.ForeColor = Color.Black; //Set the backcolor of editor.
            }
        }

        //Background color pink.
        private void ����ɫtoolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //Conditions to determine if the botton is checked.
            ����ɫtoolStripMenuItem3.Checked = !����ɫtoolStripMenuItem3.Checked; //Reverse selection.

            //Conditions to change.
            if (����ɫtoolStripMenuItem3.Checked == true)
            {
                txtMain.BackColor = Color.LavenderBlush; //Set the backcolor of editor.
                txtMain.ForeColor = Color.Black; //Set the backcolor of editor.

                //Unchecked other items.
                ����ɫtoolStripMenuItem1.Checked = false;
                ����ɫtoolStripMenuItem2.Checked = false;
            }
            if (����ɫtoolStripMenuItem3.Checked == false)
            {
                txtMain.BackColor = Color.White; //Set the backcolor of editor.
                txtMain.ForeColor = Color.Black; //Set the backcolor of editor.
            }
        }

        //Background color black in various.
        private void �ź�toolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Conditions to determine if the botton is checked.
            �ź�toolStripMenuItem.Checked = !�ź�toolStripMenuItem.Checked; //Reverse selection.

            //Conditions to change.
            if (�ź�toolStripMenuItem.Checked == true)
            {
                txtMain.BackColor = Color.Black; //Set the backcolor of editor.
                txtMain.ForeColor = Color.White; //Set the backcolor of editor.

                //Unchecked other items.
                ����toolStripMenuItem.Checked = false;
                ����toolStripMenuItem.Checked = false;
            }
            if (�ź�toolStripMenuItem.Checked == false)
            {
                txtMain.BackColor = Color.White; //Set the backcolor of editor.
                txtMain.ForeColor = Color.Black; //Set the backcolor of editor.
            }
        }

        //Background color white in various.
        private void ����toolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Conditions to determine if the botton is checked.
            ����toolStripMenuItem.Checked = !����toolStripMenuItem.Checked; //Reverse selection.

            //Conditions to change.
            if (����toolStripMenuItem.Checked == true)
            {
                txtMain.BackColor = Color.White; //Set the backcolor of editor.
                txtMain.ForeColor = Color.Black; //Set the backcolor of editor.

                //Unchecked other items.
                �ź�toolStripMenuItem.Checked = false;
                ����toolStripMenuItem.Checked = false;
            }
            if (����toolStripMenuItem.Checked == false)
            {
                txtMain.BackColor = Color.White; //Set the backcolor of editor.
                txtMain.ForeColor = Color.Black; //Set the backcolor of editor.
            }
        }

        //Background color pink in various.
        private void ����toolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Conditions to determine if the botton is checked.
            ����toolStripMenuItem.Checked = !����toolStripMenuItem.Checked; //Reverse selection.

            //Conditions to change.
            if (����toolStripMenuItem.Checked == true)
            {
                txtMain.BackColor = Color.LavenderBlush; //Set the backcolor of editor.
                txtMain.ForeColor = Color.Black; //Set the backcolor of editor.

                //Unchecked other items.
                �ź�toolStripMenuItem.Checked = false;
                ����toolStripMenuItem.Checked = false;
            }
            if (����toolStripMenuItem.Checked == false)
            {
                txtMain.BackColor = Color.White; //Set the backcolor of editor.
                txtMain.ForeColor = Color.Black; //Set the backcolor of editor.
            }
        }

        //Set the font of all text in the container.
        private void �༭����������toolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog(); //Public a new class of FontDialog.
            fontDialog.ShowColor = true; //Let the fontdialog can show color choose.
            fontDialog.Font = txtMain.Font; //Set the showed font of Fontdialog.
            fontDialog.Color = txtMain.ForeColor; //Set the showed color of Fontdialog.
            if (fontDialog.ShowDialog() == DialogResult.OK) //Set a condition to determine if you click the button of OK.
            {
                Font font = fontDialog.Font; //Public a new class of font.
                txtMain.Font = font; //Let the selected text use the font you choose.
                Color color = fontDialog.Color; //Public a new class of color.
                txtMain.ForeColor = color; //Let the selected text use the color you choose.
            }
        }

        //Menu background color black.
        private void �˵���toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Conditions to determine if the botton is checked.
            �˵���toolStripMenuItem1.Checked = !�˵���toolStripMenuItem1.Checked; //Reverse selection.

            //Conditions to change.
            if (�˵���toolStripMenuItem1.Checked == true)
            {
                menuStrip1.BackColor = Color.Black; //Set the backcolor of menuStrip1.
                menuStrip1.ForeColor = Color.White; //Set the forecolor of menuStrip1.

                //Unchecked other items.
                �˵���toolStripMenuItem2.Checked = false;
                �˵���toolStripMenuItem3.Checked = false;
                �˵���toolStripMenuItem4.Checked = false;
            }
            if (�˵���toolStripMenuItem1.Checked == false)
            {
                menuStrip1.BackColor = Color.Thistle; //Set the backcolor of menuStrip1.
                menuStrip1.ForeColor = Color.Black; //Set the forecolor of menuStrip1.
            }
        }

        //Menu background color white.
        private void �˵���toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //Conditions to determine if the botton is checked.
            �˵���toolStripMenuItem2.Checked = !�˵���toolStripMenuItem2.Checked; //Reverse selection.

            //Conditions to change.
            if (�˵���toolStripMenuItem2.Checked == true)
            {
                menuStrip1.BackColor = Color.White; //Set the backcolor of menuStrip1.
                menuStrip1.ForeColor = Color.Black; //Set the forecolor of menuStrip1.

                //Unchecked other items.
                �˵���toolStripMenuItem1.Checked = false;
                �˵���toolStripMenuItem3.Checked = false;
                �˵���toolStripMenuItem4.Checked = false;
            }
            if (�˵���toolStripMenuItem2.Checked == false)
            {
                menuStrip1.BackColor = Color.Thistle; //Set the backcolor of menuStrip1.
                menuStrip1.ForeColor = Color.Black; //Set the forecolor of menuStrip1.
            }
        }

        //Menu background color pink.
        private void �˵���toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //Conditions to determine if the botton is checked.
            �˵���toolStripMenuItem3.Checked = !�˵���toolStripMenuItem3.Checked; //Reverse selection.

            //Conditions to change.
            if (�˵���toolStripMenuItem3.Checked == true)
            {
                menuStrip1.BackColor = Color.Thistle; //Set the backcolor of menuStrip1.
                menuStrip1.ForeColor = Color.Black; //Set the forecolor of menuStrip1.

                //Unchecked other items.
                �˵���toolStripMenuItem1.Checked = false;
                �˵���toolStripMenuItem2.Checked = false;
                �˵���toolStripMenuItem4.Checked = false;
            }
            if (�˵���toolStripMenuItem3.Checked == false)
            {
                menuStrip1.BackColor = Color.Thistle; //Set the backcolor of menuStrip1.
                menuStrip1.ForeColor = Color.Black; //Set the forecolor of menuStrip1.
            }
        }

        //Menu background color blue.
        private void �˵���toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            //Conditions to determine if the botton is checked.
            �˵���toolStripMenuItem4.Checked = !�˵���toolStripMenuItem4.Checked; //Reverse selection.

            //Conditions to change.
            if (�˵���toolStripMenuItem4.Checked == true)
            {
                menuStrip1.BackColor = Color.DeepSkyBlue; //Set the backcolor of menuStrip1.
                menuStrip1.ForeColor = Color.White; //Set the forecolor of menuStrip1.

                //Unchecked other items.
                �˵���toolStripMenuItem1.Checked = false;
                �˵���toolStripMenuItem2.Checked = false;
                �˵���toolStripMenuItem3.Checked = false;
            }
            if (�˵���toolStripMenuItem4.Checked == false)
            {
                menuStrip1.BackColor = Color.Thistle; //Set the backcolor of menuStrip1.
                menuStrip1.ForeColor = Color.Black; //Set the forecolor of menuStrip1.
            }
        }

        //Tool bar background color black.
        private void ������toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            //Conditions to determine if the botton is checked.
            ������toolStripMenuItem11.Checked = !������toolStripMenuItem11.Checked; //Reverse selection.

            //Conditions to change.
            if (������toolStripMenuItem11.Checked == true)
            {
                toolStrip1.BackColor = Color.Gainsboro; //Set the backcolor of toolStrip1.
                toolStrip1.ForeColor = Color.Black; //Set the backcolor of toolStrip1.

                //Unchecked other items.
                ������toolStripMenuItem12.Checked = false;
                ������toolStripMenuItem13.Checked = false;
                ������toolStripMenuItem14.Checked = false;
            }
            if (������toolStripMenuItem11.Checked == false)
            {
                toolStrip1.BackColor = Color.LavenderBlush; //Set the backcolor of toolStrip1.
                toolStrip1.ForeColor = Color.Black; //Set the backcolor of toolStrip1.
            }
        }

        //Tool bar background color white.
        private void ������toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            //Conditions to determine if the botton is checked.
            ������toolStripMenuItem12.Checked = !������toolStripMenuItem12.Checked; //Reverse selection.

            //Conditions to change.
            if (������toolStripMenuItem12.Checked == true)
            {
                toolStrip1.BackColor = SystemColors.Control; //Set the backcolor of toolStrip1.
                toolStrip1.ForeColor = SystemColors.ControlText; //Set the backcolor of toolStrip1.

                //Unchecked other items.
                ������toolStripMenuItem11.Checked = false;
                ������toolStripMenuItem13.Checked = false;
                ������toolStripMenuItem14.Checked = false;
            }
            if (������toolStripMenuItem12.Checked == false)
            {
                toolStrip1.BackColor = Color.LavenderBlush; //Set the backcolor of toolStrip1.
                toolStrip1.ForeColor = Color.Black; //Set the backcolor of toolStrip1.
            }
        }

        //Tool bar background color pink.
        private void ������toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            //Conditions to determine if the botton is checked.
            ������toolStripMenuItem13.Checked = !������toolStripMenuItem13.Checked; //Reverse selection.

            //Conditions to change.
            if (������toolStripMenuItem13.Checked == true)
            {
                toolStrip1.BackColor = Color.LavenderBlush; //Set the backcolor of toolStrip1.
                toolStrip1.ForeColor = Color.Black; //Set the backcolor of toolStrip1.

                //Unchecked other items.
                ������toolStripMenuItem11.Checked = false;
                ������toolStripMenuItem12.Checked = false;
                ������toolStripMenuItem14.Checked = false;
            }
            if (������toolStripMenuItem13.Checked == false)
            {
                toolStrip1.BackColor = Color.LavenderBlush; //Set the backcolor of toolStrip1.
                toolStrip1.ForeColor = Color.Black; //Set the backcolor of toolStrip1.
            }
        }

        //Tool bar background color blue.
        private void ������toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            //Conditions to determine if the botton is checked.
            ������toolStripMenuItem14.Checked = !������toolStripMenuItem14.Checked; //Reverse selection.

            //Conditions to change.
            if (������toolStripMenuItem14.Checked == true)
            {
                toolStrip1.BackColor = Color.AliceBlue; //Set the backcolor of toolStrip1.
                toolStrip1.ForeColor = Color.Black; //Set the backcolor of toolStrip1.

                //Unchecked other items.
                ������toolStripMenuItem11.Checked = false;
                ������toolStripMenuItem12.Checked = false;
                ������toolStripMenuItem13.Checked = false;
            }
            if (������toolStripMenuItem14.Checked == false)
            {
                toolStrip1.BackColor = Color.LavenderBlush; //Set the backcolor of toolStrip1.
                toolStrip1.ForeColor = Color.Black; //Set the backcolor of toolStrip1.
            }
        }

        //Editor background color black.
        private void �༭��toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            //Conditions to determine if the botton is checked.
            �༭��toolStripMenuItem15.Checked = !�༭��toolStripMenuItem15.Checked; //Reverse selection.

            //Conditions to change.
            if (�༭��toolStripMenuItem15.Checked == true)
            {
                txtMain.BackColor = Color.Gainsboro; //Set the backcolor of editor.
                txtMain.ForeColor = Color.Black; //Set the forecolor of editor.

                //Unchecked other items.
                �༭��toolStripMenuItem16.Checked = false;
                �༭��toolStripMenuItem17.Checked = false;
                �༭��toolStripMenuItem18.Checked = false;
            }
            if (�༭��toolStripMenuItem15.Checked == false)
            {
                txtMain.BackColor = Color.White; //Set the backcolor of editor.
                txtMain.ForeColor = Color.Black; //Set the forecolor of editor.
            }
        }

        //Editor background color white.
        private void �༭��toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            //Conditions to determine if the botton is checked.
            �༭��toolStripMenuItem16.Checked = !�༭��toolStripMenuItem16.Checked; //Reverse selection.

            //Conditions to change.
            if (�༭��toolStripMenuItem16.Checked == true)
            {
                txtMain.BackColor = Color.White; //Set the backcolor of editor.
                txtMain.ForeColor = Color.Black; //Set the forecolor of editor.

                //Unchecked other items.
                �༭��toolStripMenuItem15.Checked = false;
                �༭��toolStripMenuItem17.Checked = false;
                �༭��toolStripMenuItem18.Checked = false;
            }
            if (�༭��toolStripMenuItem16.Checked == false)
            {
                txtMain.BackColor = Color.White; //Set the backcolor of editor.
                txtMain.ForeColor = Color.Black; //Set the forecolor of editor.
            }
        }

        //Editor background color pink.
        private void �༭��toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            //Conditions to determine if the botton is checked.
            �༭��toolStripMenuItem17.Checked = !�༭��toolStripMenuItem17.Checked; //Reverse selection.

            //Conditions to change.
            if (�༭��toolStripMenuItem17.Checked == true)
            {
                txtMain.BackColor = Color.LavenderBlush; //Set the backcolor of editor.
                txtMain.ForeColor = Color.Black; //Set the forecolor of editor.

                //Unchecked other items.
                �༭��toolStripMenuItem15.Checked = false;
                �༭��toolStripMenuItem16.Checked = false;
                �༭��toolStripMenuItem18.Checked = false;
            }
            if (�༭��toolStripMenuItem17.Checked == false)
            {
                txtMain.BackColor = Color.White; //Set the backcolor of editor.
                txtMain.ForeColor = Color.Black; //Set the forecolor of editor.
            }
        }

        //Editor background color blue.
        private void �༭��toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            //Conditions to determine if the botton is checked.
            �༭��toolStripMenuItem18.Checked = !�༭��toolStripMenuItem18.Checked; //Reverse selection.

            //Conditions to change.
            if (�༭��toolStripMenuItem18.Checked == true)
            {
                txtMain.BackColor = Color.AliceBlue; //Set the backcolor of editor.
                txtMain.ForeColor = Color.Black; //Set the forecolor of editor.

                //Unchecked other items.
                �༭��toolStripMenuItem15.Checked = false;
                �༭��toolStripMenuItem16.Checked = false;
                �༭��toolStripMenuItem17.Checked = false;
            }
            if (�༭��toolStripMenuItem18.Checked == false)
            {
                txtMain.BackColor = Color.White; //Set the backcolor of editor.
                txtMain.ForeColor = Color.Black; //Set the forecolor of editor.
            }
        }

        //Status menu background color black.
        private void ״̬��toolStripMenuItem19_Click(object sender, EventArgs e)
        {
            //Conditions to determine if the botton is checked.
            ״̬��toolStripMenuItem19.Checked = !״̬��toolStripMenuItem19.Checked; //Reverse selection.

            //Conditions to change.
            if (״̬��toolStripMenuItem19.Checked == true)
            {
                statusStrip1.BackColor = Color.Black; //Set the backcolor of statusStrip1.
                statusStrip1.ForeColor = Color.White; //Set the forecolor of statusStrip1.

                //Unchecked other items.
                ״̬��toolStripMenuItem20.Checked = false;
                ״̬��toolStripMenuItem21.Checked = false;
                ״̬��toolStripMenuItem22.Checked = false;
            }
            if (״̬��toolStripMenuItem19.Checked == false)
            {
                statusStrip1.BackColor = Color.Thistle; //Set the backcolor of statusStrip1.
                statusStrip1.ForeColor = Color.Black; //Set the forecolor of statusStrip1.
            }
        }

        //Status menu background color white.
        private void ״̬��toolStripMenuItem20_Click(object sender, EventArgs e)
        {
            //Conditions to determine if the botton is checked.
            ״̬��toolStripMenuItem20.Checked = !״̬��toolStripMenuItem20.Checked; //Reverse selection.

            //Conditions to change.
            if (״̬��toolStripMenuItem20.Checked == true)
            {
                statusStrip1.BackColor = SystemColors.Control; //Set the backcolor of statusStrip1.
                statusStrip1.ForeColor = SystemColors.ControlText; //Set the forecolor of statusStrip1.

                //Unchecked other items.
                ״̬��toolStripMenuItem19.Checked = false;
                ״̬��toolStripMenuItem21.Checked = false;
                ״̬��toolStripMenuItem22.Checked = false;
            }
            if (״̬��toolStripMenuItem20.Checked == false)
            {
                statusStrip1.BackColor = Color.Thistle; //Set the backcolor of statusStrip1.
                statusStrip1.ForeColor = Color.Black; //Set the forecolor of statusStrip1.
            }
        }

        //Status menu background color pink.
        private void ״̬��toolStripMenuItem21_Click(object sender, EventArgs e)
        {
            //Conditions to determine if the botton is checked.
            ״̬��toolStripMenuItem21.Checked = !״̬��toolStripMenuItem21.Checked; //Reverse selection.

            //Conditions to change.
            if (״̬��toolStripMenuItem21.Checked == true)
            {
                statusStrip1.BackColor = Color.Thistle; //Set the backcolor of statusStrip1.
                statusStrip1.ForeColor = Color.Black; //Set the forecolor of statusStrip1.

                //Unchecked other items.
                ״̬��toolStripMenuItem19.Checked = false;
                ״̬��toolStripMenuItem20.Checked = false;
                ״̬��toolStripMenuItem22.Checked = false;
            }
            if (״̬��toolStripMenuItem21.Checked == false)
            {
                statusStrip1.BackColor = Color.Thistle; //Set the backcolor of statusStrip1.
                statusStrip1.ForeColor = Color.Black; //Set the forecolor of statusStrip1.
            }
        }

        //Status menu background color blue.
        private void ״̬��toolStripMenuItem22_Click(object sender, EventArgs e)
        {
            //Conditions to determine if the botton is checked.
            ״̬��toolStripMenuItem22.Checked = !״̬��toolStripMenuItem22.Checked; //Reverse selection.

            //Conditions to change.
            if (״̬��toolStripMenuItem22.Checked == true)
            {
                statusStrip1.BackColor = Color.DeepSkyBlue; //Set the backcolor of statusStrip1.
                statusStrip1.ForeColor = Color.White; //Set the forecolor of statusStrip1.

                //Unchecked other items.
                ״̬��toolStripMenuItem19.Checked = false;
                ״̬��toolStripMenuItem20.Checked = false;
                ״̬��toolStripMenuItem21.Checked = false;
            }
            if (״̬��toolStripMenuItem22.Checked == false)
            {
                statusStrip1.BackColor = Color.Thistle; //Set the backcolor of statusStrip1.
                statusStrip1.ForeColor = Color.Black; //Set the forecolor of statusStrip1.
            }
        }

        //Search text.
        private void ��ʼ����toolStripMenuItem_Click(object sender, EventArgs e)
        {
            string searchText = SearchTextBox.Text; //Define a string data called searchText to read the text of SearchTextBox.
            txtMain.Find(searchText); //Use the system function called Find on the editor to locate the text you want.
        }

        //Divide Line.
        private void �ָ���toolStripButton_Click(object sender, EventArgs e)
        {
            int EditorWidth = txtMain.Width / 15; //Get the width of editor.
            string DevideLine = new string('��', EditorWidth); //Set a string of '-' and use the width to calculate the length of the string.
            if (txtMain.Text == string.Empty) //Condition of editor is empty.
            {
                txtMain.AppendText(DevideLine); //Add the time now after the text it already exit.
                txtMain.AppendText("\n"); //Wrap.
            }
            else
            {
                txtMain.AppendText("\n"); //Wrap.
                txtMain.AppendText(DevideLine); //Add the time now after the text it already exit.
                txtMain.AppendText("\n"); //Wrap.
            }
        }

        //Change in the menu.
        private void ChangetoolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMain.SelectedText = toolStripTextBox3.Text; //Let the text selected in the editor exchanged to the text you input in the toolstriptextbox2.
        }


        //-------------------------------------------------------
        //The code of statusStrip stretch.
        //50%
        private void toolStripMenuItem50_Click(object sender, EventArgs e)
        {
            //Conditions to determine if the botton is checked.
            toolStripMenuItem50.Checked = !toolStripMenuItem50.Checked; //Reverse selection.

            //Conditions to change.
            if (toolStripMenuItem50.Checked == true)
            {
                txtMain.ZoomFactor = (float)0.5; //Set the zoom factor 50%.

                //Unchecked other items.
                toolStripMenuItem80.Checked = false;
                toolStripMenuItem100.Checked = false;
                toolStripMenuItem120.Checked = false;
                toolStripMenuItem150.Checked = false;
                toolStripMenuItem180.Checked = false;
                toolStripMenuItem200.Checked = false;
                toolStripMenuItem220.Checked = false;
                toolStripMenuItem250.Checked = false;
                toolStripMenuItem300.Checked = false;
            }
            if (toolStripMenuItem50.Checked == false)
            {
                txtMain.ZoomFactor = (float)1.0; //Set the zoom factor 100%.
            }
        }

        //80%
        private void toolStripMenuItem80_Click(object sender, EventArgs e)
        {
            //Conditions to determine if the botton is checked.
            toolStripMenuItem80.Checked = !toolStripMenuItem80.Checked; //Reverse selection.

            //Conditions to change.
            if (toolStripMenuItem80.Checked == true)
            {
                txtMain.ZoomFactor = (float)0.8; //Set the zoom factor 80%.

                //Unchecked other items.
                toolStripMenuItem50.Checked = false;
                toolStripMenuItem100.Checked = false;
                toolStripMenuItem120.Checked = false;
                toolStripMenuItem150.Checked = false;
                toolStripMenuItem180.Checked = false;
                toolStripMenuItem200.Checked = false;
                toolStripMenuItem220.Checked = false;
                toolStripMenuItem250.Checked = false;
                toolStripMenuItem300.Checked = false;
            }
            if (toolStripMenuItem80.Checked == false)
            {
                txtMain.ZoomFactor = (float)1.0; //Set the zoom factor 100%.
            }
        }

        //100%
        private void toolStripMenuItem100_Click(object sender, EventArgs e)
        {
            //Conditions to determine if the botton is checked.
            toolStripMenuItem100.Checked = !toolStripMenuItem100.Checked; //Reverse selection.

            //Conditions to change.
            if (toolStripMenuItem100.Checked == true)
            {
                txtMain.ZoomFactor = (float)1.0; //Set the zoom factor 100%.

                //Unchecked other items.
                toolStripMenuItem50.Checked = false;
                toolStripMenuItem80.Checked = false;
                toolStripMenuItem120.Checked = false;
                toolStripMenuItem150.Checked = false;
                toolStripMenuItem180.Checked = false;
                toolStripMenuItem200.Checked = false;
                toolStripMenuItem220.Checked = false;
                toolStripMenuItem250.Checked = false;
                toolStripMenuItem300.Checked = false;
            }
            if (toolStripMenuItem100.Checked == false)
            {
                txtMain.ZoomFactor = (float)1.0; //Set the zoom factor 100%.
            }
        }

        //120%
        private void toolStripMenuItem120_Click(object sender, EventArgs e)
        {
            //Conditions to determine if the botton is checked.
            toolStripMenuItem120.Checked = !toolStripMenuItem120.Checked; //Reverse selection.

            //Conditions to change.
            if (toolStripMenuItem120.Checked == true)
            {
                txtMain.ZoomFactor = (float)1.2; //Set the zoom factor 120%.

                //Unchecked other items.
                toolStripMenuItem50.Checked = false;
                toolStripMenuItem80.Checked = false;
                toolStripMenuItem100.Checked = false;
                toolStripMenuItem150.Checked = false;
                toolStripMenuItem180.Checked = false;
                toolStripMenuItem200.Checked = false;
                toolStripMenuItem220.Checked = false;
                toolStripMenuItem250.Checked = false;
                toolStripMenuItem300.Checked = false;
            }
            if (toolStripMenuItem120.Checked == false)
            {
                txtMain.ZoomFactor = (float)1.0; //Set the zoom factor 100%.
            }
        }

        //150%
        private void toolStripMenuItem150_Click(object sender, EventArgs e)
        {
            //Conditions to determine if the botton is checked.
            toolStripMenuItem150.Checked = !toolStripMenuItem150.Checked; //Reverse selection.

            //Conditions to change.
            if (toolStripMenuItem150.Checked == true)
            {
                txtMain.ZoomFactor = (float)1.5; //Set the zoom factor 150%.

                //Unchecked other items.
                toolStripMenuItem50.Checked = false;
                toolStripMenuItem80.Checked = false;
                toolStripMenuItem100.Checked = false;
                toolStripMenuItem120.Checked = false;
                toolStripMenuItem180.Checked = false;
                toolStripMenuItem200.Checked = false;
                toolStripMenuItem220.Checked = false;
                toolStripMenuItem250.Checked = false;
                toolStripMenuItem300.Checked = false;
            }
            if (toolStripMenuItem150.Checked == false)
            {
                txtMain.ZoomFactor = (float)1.0; //Set the zoom factor 100%.
            }
        }

        //180%
        private void toolStripMenuItem180_Click(object sender, EventArgs e)
        {
            //Conditions to determine if the botton is checked.
            toolStripMenuItem180.Checked = !toolStripMenuItem180.Checked; //Reverse selection.

            //Conditions to change.
            if (toolStripMenuItem180.Checked == true)
            {
                txtMain.ZoomFactor = (float)1.8; //Set the zoom factor 180%.

                //Unchecked other items.
                toolStripMenuItem50.Checked = false;
                toolStripMenuItem80.Checked = false;
                toolStripMenuItem100.Checked = false;
                toolStripMenuItem120.Checked = false;
                toolStripMenuItem150.Checked = false;
                toolStripMenuItem200.Checked = false;
                toolStripMenuItem220.Checked = false;
                toolStripMenuItem250.Checked = false;
                toolStripMenuItem300.Checked = false;
            }
            if (toolStripMenuItem180.Checked == false)
            {
                txtMain.ZoomFactor = (float)1.0; //Set the zoom factor 100%.
            }
        }

        //200%
        private void toolStripMenuItem200_Click(object sender, EventArgs e)
        {
            //Conditions to determine if the botton is checked.
            toolStripMenuItem200.Checked = !toolStripMenuItem200.Checked; //Reverse selection.

            //Conditions to change.
            if (toolStripMenuItem200.Checked == true)
            {
                txtMain.ZoomFactor = (float)2.0; //Set the zoom factor 200%.

                //Unchecked other items.
                toolStripMenuItem50.Checked = false;
                toolStripMenuItem80.Checked = false;
                toolStripMenuItem100.Checked = false;
                toolStripMenuItem120.Checked = false;
                toolStripMenuItem150.Checked = false;
                toolStripMenuItem180.Checked = false;
                toolStripMenuItem220.Checked = false;
                toolStripMenuItem250.Checked = false;
                toolStripMenuItem300.Checked = false;
            }
            if (toolStripMenuItem200.Checked == false)
            {
                txtMain.ZoomFactor = (float)1.0; //Set the zoom factor 100%.
            }
        }

        //220%
        private void toolStripMenuItem220_Click(object sender, EventArgs e)
        {
            //Conditions to determine if the botton is checked.
            toolStripMenuItem220.Checked = !toolStripMenuItem220.Checked; //Reverse selection.

            //Conditions to change.
            if (toolStripMenuItem220.Checked == true)
            {
                txtMain.ZoomFactor = (float)2.2; //Set the zoom factor 220%.

                //Unchecked other items.
                toolStripMenuItem50.Checked = false;
                toolStripMenuItem80.Checked = false;
                toolStripMenuItem100.Checked = false;
                toolStripMenuItem120.Checked = false;
                toolStripMenuItem150.Checked = false;
                toolStripMenuItem180.Checked = false;
                toolStripMenuItem200.Checked = false;
                toolStripMenuItem250.Checked = false;
                toolStripMenuItem300.Checked = false;
            }
            if (toolStripMenuItem220.Checked == false)
            {
                txtMain.ZoomFactor = (float)1.0; //Set the zoom factor 100%.
            }
        }

        //250%
        private void toolStripMenuItem250_Click(object sender, EventArgs e)
        {
            //Conditions to determine if the botton is checked.
            toolStripMenuItem250.Checked = !toolStripMenuItem250.Checked; //Reverse selection.

            //Conditions to change.
            if (toolStripMenuItem250.Checked == true)
            {
                txtMain.ZoomFactor = (float)2.5; //Set the zoom factor 250%.

                //Unchecked other items.
                toolStripMenuItem50.Checked = false;
                toolStripMenuItem80.Checked = false;
                toolStripMenuItem100.Checked = false;
                toolStripMenuItem120.Checked = false;
                toolStripMenuItem150.Checked = false;
                toolStripMenuItem180.Checked = false;
                toolStripMenuItem200.Checked = false;
                toolStripMenuItem220.Checked = false;
                toolStripMenuItem300.Checked = false;
            }
            if (toolStripMenuItem250.Checked == false)
            {
                txtMain.ZoomFactor = (float)1.0; //Set the zoom factor 100%.
            }
        }

        //300%
        private void toolStripMenuItem300_Click(object sender, EventArgs e)
        {
            //Conditions to determine if the botton is checked.
            toolStripMenuItem300.Checked = !toolStripMenuItem300.Checked; //Reverse selection.

            //Conditions to change.
            if (toolStripMenuItem300.Checked == true)
            {
                txtMain.ZoomFactor = (float)3.0; //Set the zoom factor 300%.

                //Unchecked other items.
                toolStripMenuItem50.Checked = false;
                toolStripMenuItem80.Checked = false;
                toolStripMenuItem100.Checked = false;
                toolStripMenuItem120.Checked = false;
                toolStripMenuItem150.Checked = false;
                toolStripMenuItem180.Checked = false;
                toolStripMenuItem200.Checked = false;
                toolStripMenuItem220.Checked = false;
                toolStripMenuItem250.Checked = false;
            }
            if (toolStripMenuItem300.Checked == false)
            {
                txtMain.ZoomFactor = (float)1.0; //Set the zoom factor 100%.
            }
        }

        //�˵���50%
        private void toolStripMenuItem31_Click(object sender, EventArgs e)
        {
            //Conditions to determine if the botton is checked.
            toolStripMenuItem31.Checked = !toolStripMenuItem31.Checked; //Reverse selection.

            //Conditions to change.
            if (toolStripMenuItem31.Checked == true)
            {
                txtMain.ZoomFactor = (float)0.5; //Set the zoom factor 50%.

                //Unchecked other items.
                toolStripMenuItem32.Checked = false;
                toolStripMenuItem33.Checked = false;
                toolStripMenuItem35.Checked = false;
                toolStripMenuItem36.Checked = false;
                toolStripMenuItem37.Checked = false;
                toolStripMenuItem38.Checked = false;
                toolStripMenuItem39.Checked = false;
                toolStripMenuItem40.Checked = false;
                toolStripMenuItem41.Checked = false;
            }
            if (toolStripMenuItem31.Checked == false)
            {
                txtMain.ZoomFactor = (float)1.0; //Set the zoom factor 100%.
            }
        }

        //�˵���80%
        private void toolStripMenuItem41_Click(object sender, EventArgs e)
        {
            //Conditions to determine if the botton is checked.
            toolStripMenuItem41.Checked = !toolStripMenuItem41.Checked; //Reverse selection.

            //Conditions to change.
            if (toolStripMenuItem41.Checked == true)
            {
                txtMain.ZoomFactor = (float)0.8; //Set the zoom factor 50%.

                //Unchecked other items.
                toolStripMenuItem31.Checked = false;
                toolStripMenuItem32.Checked = false;
                toolStripMenuItem33.Checked = false;
                toolStripMenuItem35.Checked = false;
                toolStripMenuItem36.Checked = false;
                toolStripMenuItem37.Checked = false;
                toolStripMenuItem38.Checked = false;
                toolStripMenuItem39.Checked = false;
                toolStripMenuItem40.Checked = false;
            }
            if (toolStripMenuItem41.Checked == false)
            {
                txtMain.ZoomFactor = (float)1.0; //Set the zoom factor 100%.
            }
        }

        //�˵���100%
        private void toolStripMenuItem32_Click(object sender, EventArgs e)
        {
            //Conditions to determine if the botton is checked.
            toolStripMenuItem32.Checked = !toolStripMenuItem32.Checked; //Reverse selection.

            //Conditions to change.
            if (toolStripMenuItem32.Checked == true)
            {
                txtMain.ZoomFactor = (float)1.0; //Set the zoom factor 50%.

                //Unchecked other items.
                toolStripMenuItem31.Checked = false;
                toolStripMenuItem33.Checked = false;
                toolStripMenuItem35.Checked = false;
                toolStripMenuItem36.Checked = false;
                toolStripMenuItem37.Checked = false;
                toolStripMenuItem38.Checked = false;
                toolStripMenuItem39.Checked = false;
                toolStripMenuItem40.Checked = false;
                toolStripMenuItem41.Checked = false;
            }
            if (toolStripMenuItem32.Checked == false)
            {
                txtMain.ZoomFactor = (float)1.0; //Set the zoom factor 100%.
            }
        }

        //�˵���120%
        private void toolStripMenuItem33_Click(object sender, EventArgs e)
        {
            //Conditions to determine if the botton is checked.
            toolStripMenuItem33.Checked = !toolStripMenuItem33.Checked; //Reverse selection.

            //Conditions to change.
            if (toolStripMenuItem33.Checked == true)
            {
                txtMain.ZoomFactor = (float)1.2; //Set the zoom factor 50%.

                //Unchecked other items.
                toolStripMenuItem31.Checked = false;
                toolStripMenuItem32.Checked = false;
                toolStripMenuItem35.Checked = false;
                toolStripMenuItem36.Checked = false;
                toolStripMenuItem37.Checked = false;
                toolStripMenuItem38.Checked = false;
                toolStripMenuItem39.Checked = false;
                toolStripMenuItem40.Checked = false;
                toolStripMenuItem41.Checked = false;
            }
            if (toolStripMenuItem33.Checked == false)
            {
                txtMain.ZoomFactor = (float)1.0; //Set the zoom factor 100%.
            }
        }

        //�˵���150%
        private void toolStripMenuItem35_Click(object sender, EventArgs e)
        {
            //Conditions to determine if the botton is checked.
            toolStripMenuItem35.Checked = !toolStripMenuItem35.Checked; //Reverse selection.

            //Conditions to change.
            if (toolStripMenuItem35.Checked == true)
            {
                txtMain.ZoomFactor = (float)1.5; //Set the zoom factor 50%.

                //Unchecked other items.
                toolStripMenuItem31.Checked = false;
                toolStripMenuItem32.Checked = false;
                toolStripMenuItem33.Checked = false;
                toolStripMenuItem36.Checked = false;
                toolStripMenuItem37.Checked = false;
                toolStripMenuItem38.Checked = false;
                toolStripMenuItem39.Checked = false;
                toolStripMenuItem40.Checked = false;
                toolStripMenuItem41.Checked = false;
            }
            if (toolStripMenuItem35.Checked == false)
            {
                txtMain.ZoomFactor = (float)1.0; //Set the zoom factor 100%.
            }
        }

        //�˵���180%
        private void toolStripMenuItem36_Click(object sender, EventArgs e)
        {
            //Conditions to determine if the botton is checked.
            toolStripMenuItem36.Checked = !toolStripMenuItem36.Checked; //Reverse selection.

            //Conditions to change.
            if (toolStripMenuItem36.Checked == true)
            {
                txtMain.ZoomFactor = (float)1.8; //Set the zoom factor 50%.

                //Unchecked other items.
                toolStripMenuItem31.Checked = false;
                toolStripMenuItem32.Checked = false;
                toolStripMenuItem33.Checked = false;
                toolStripMenuItem35.Checked = false;
                toolStripMenuItem37.Checked = false;
                toolStripMenuItem38.Checked = false;
                toolStripMenuItem39.Checked = false;
                toolStripMenuItem40.Checked = false;
                toolStripMenuItem41.Checked = false;
            }
            if (toolStripMenuItem36.Checked == false)
            {
                txtMain.ZoomFactor = (float)1.0; //Set the zoom factor 100%.
            }
        }

        //�˵���200%
        private void toolStripMenuItem37_Click(object sender, EventArgs e)
        {
            //Conditions to determine if the botton is checked.
            toolStripMenuItem37.Checked = !toolStripMenuItem37.Checked; //Reverse selection.

            //Conditions to change.
            if (toolStripMenuItem37.Checked == true)
            {
                txtMain.ZoomFactor = (float)2.0; //Set the zoom factor 50%.

                //Unchecked other items.
                toolStripMenuItem31.Checked = false;
                toolStripMenuItem32.Checked = false;
                toolStripMenuItem33.Checked = false;
                toolStripMenuItem35.Checked = false;
                toolStripMenuItem36.Checked = false;
                toolStripMenuItem38.Checked = false;
                toolStripMenuItem39.Checked = false;
                toolStripMenuItem40.Checked = false;
                toolStripMenuItem41.Checked = false;
            }
            if (toolStripMenuItem37.Checked == false)
            {
                txtMain.ZoomFactor = (float)1.0; //Set the zoom factor 100%.
            }
        }

        //�˵���220%
        private void toolStripMenuItem38_Click(object sender, EventArgs e)
        {
            //Conditions to determine if the botton is checked.
            toolStripMenuItem38.Checked = !toolStripMenuItem38.Checked; //Reverse selection.

            //Conditions to change.
            if (toolStripMenuItem38.Checked == true)
            {
                txtMain.ZoomFactor = (float)2.2; //Set the zoom factor 50%.

                //Unchecked other items.
                toolStripMenuItem31.Checked = false;
                toolStripMenuItem32.Checked = false;
                toolStripMenuItem33.Checked = false;
                toolStripMenuItem35.Checked = false;
                toolStripMenuItem36.Checked = false;
                toolStripMenuItem37.Checked = false;
                toolStripMenuItem39.Checked = false;
                toolStripMenuItem40.Checked = false;
                toolStripMenuItem41.Checked = false;
            }
            if (toolStripMenuItem38.Checked == false)
            {
                txtMain.ZoomFactor = (float)1.0; //Set the zoom factor 100%.
            }
        }

        //�˵���250%
        private void toolStripMenuItem39_Click(object sender, EventArgs e)
        {
            //Conditions to determine if the botton is checked.
            toolStripMenuItem39.Checked = !toolStripMenuItem39.Checked; //Reverse selection.

            //Conditions to change.
            if (toolStripMenuItem39.Checked == true)
            {
                txtMain.ZoomFactor = (float)2.5; //Set the zoom factor 50%.

                //Unchecked other items.
                toolStripMenuItem31.Checked = false;
                toolStripMenuItem32.Checked = false;
                toolStripMenuItem33.Checked = false;
                toolStripMenuItem35.Checked = false;
                toolStripMenuItem36.Checked = false;
                toolStripMenuItem37.Checked = false;
                toolStripMenuItem38.Checked = false;
                toolStripMenuItem40.Checked = false;
                toolStripMenuItem41.Checked = false;
            }
            if (toolStripMenuItem39.Checked == false)
            {
                txtMain.ZoomFactor = (float)1.0; //Set the zoom factor 100%.
            }
        }

        //�˵���300%
        private void toolStripMenuItem40_Click(object sender, EventArgs e)
        {
            //Conditions to determine if the botton is checked.
            toolStripMenuItem40.Checked = !toolStripMenuItem40.Checked; //Reverse selection.

            //Conditions to change.
            if (toolStripMenuItem40.Checked == true)
            {
                txtMain.ZoomFactor = (float)3.0; //Set the zoom factor 50%.

                //Unchecked other items.
                toolStripMenuItem31.Checked = false;
                toolStripMenuItem32.Checked = false;
                toolStripMenuItem33.Checked = false;
                toolStripMenuItem35.Checked = false;
                toolStripMenuItem36.Checked = false;
                toolStripMenuItem37.Checked = false;
                toolStripMenuItem38.Checked = false;
                toolStripMenuItem39.Checked = false;
                toolStripMenuItem41.Checked = false;
            }
            if (toolStripMenuItem40.Checked == false)
            {
                txtMain.ZoomFactor = (float)1.0; //Set the zoom factor 100%.
            }
        }


        //-------------------------------------------------------
        //The code of application using.
        //Do since closing the application.
        private void Notebook_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("ϵͳ��ʾ���˳�Ӧ��֮ǰ���Ƿ�Ҫ���浱ǰ�༭���ļ�������Ҫ�˳�Ӧ�������Ե���������б��棬�����������������˳�Ӧ�á�����������˳�Ӧ������ȡ����رմ��ڡ�\nע�⣬�����ǰ�༭���ļ�Ϊ���ش��ļ���ֱ�ӱ��棬�Ǳ��ش��ļ�����Ҫ�½�·�������档", "Warning", MessageBoxButtons.YesNoCancel); //System warning to tell the user,and messagebox use the format of OKCancel.
            if (dr == DialogResult.Yes) //Make the DialogResult's result to be the condition.
            {
                e.Cancel = false;
                if (savepath != string.Empty) 
                {
                    txtMain.SaveFile(savepath, RichTextBoxStreamType.PlainText); //Save the file of PlainText on the path you choose.
                    MessageBox.Show("�ļ��ɹ����浽·����" + savepath + "\n��л����ʹ�ã�", "Result"); //Show the result of the saving.
                    savepath = ""; //Reset the savepath.
                }
                else if (savepath == string.Empty)
                {
                    MessageBox.Show("����ǰ��δ�򿪱����ļ������½�·�������棡", "Warning"); //Warning.
                    SaveFileDialog saveFileDialog = new SaveFileDialog(); //Public a new class of SaveFileDialog.
                    saveFileDialog.Title = "�Ƿ�Ҫ���浱ǰ�༭���ļ���"; //Set the SaveFileDialog form's name.
                    saveFileDialog.Filter = "�ı��ļ�|*.txt|DOC�ĵ�|*.doc|DOCX�ļ�|*.docx|HTM�ļ�|*.htm|HTML�ļ�|*.html|CSSԴ�ļ�|*.css|JavaScriptԴ�ļ�|*.js|C#Դ�ļ�|*.cs|C����Դ�ļ�|*.c|C++Դ�ļ�|*.cpp|JavaԴ�ļ�|*.java|PythonԴ�ļ�|*.py|R����Դ�ļ�|*.R|PHPԴ�ļ�|*.php|�����ļ�|*"; //Set the class of file which you can choose to save.
                    if (saveFileDialog.ShowDialog() == DialogResult.OK) //Set a condition to determine if you click the botton of OK.
                    {
                        //MessageBox.Show(openFileDialog.FileName);
                        string path = saveFileDialog.FileName; //Define the path of the file.
                        txtMain.SaveFile(path, RichTextBoxStreamType.PlainText); //Save the file of PlainText on the path you choose.
                        MessageBox.Show("�ļ��ɹ����浽·����" + path + "\n��л����ʹ�ã�", "Result"); //Show the result of the saving.
                    }
                    else //Else condition.
                    {
                        MessageBox.Show("���ѷ����Ե�ǰ�ļ��ı���!" + "\n��л����ʹ�ã�", "Goodbye"); //Show the result of the saving.
                    }
                }
            }
            else if (dr == DialogResult.No) //Make the DialogResult's result to be the condition.
            {
                MessageBox.Show("���ѷ����Ե�ǰ�ļ��ı���!" + "\n��л����ʹ�ã�", "Goodbye"); //Show the result of the saving.
            }
            else if (dr == DialogResult.Cancel)
            {
                e.Cancel = true; //Let the application can not be closed.
            }
        }

        //Start the timer when you open the application.
        /*private void Notebook_Load(object sender, EventArgs e)
        {
            Random random = new Random();����//��ѭ�������ʼ��
            int figure = random.Next(1, 4); //�������1��4�����е�����
            if (figure == 1) 
            {
                MessageBox.Show("��ӭʹ��My Notebook 1.1.4!�����������������\nʱ�����ۣ�Ը����һ��������Ҫ�����طꡣ\nby Error","Welcome");
            }
            if (figure == 2)
            {
                MessageBox.Show("��ӭʹ��My Notebook 1.1.4!�����������������\n�ط��ʱ��ϣ������β���֧�����顣\nby Error", "Welcome");
            }
            if (figure == 3)
            {
                MessageBox.Show("��ӭʹ��My Notebook 1.1.4!�����������������\n��£�����Σ���ת�����ƣ�ʱ�����أ���Ъ�������ᡣ�����ʱ�䡣\nby Error", "Welcome");
            }
            if (figure == 4)
            {
                MessageBox.Show("��ӭʹ��My Notebook 1.1.4!�����������������\n��ʱ����Խ���ã���Խ�����⵽����ķ��ɡ�������Ϊ��һ����û�л��䣬�����Ǹ������ġ�\nby Error", "Welcome");
            }
            Time.Text = System.DateTime.Now.ToString(); //Show the time now in the Time Statuslabel.
            timer.Interval = 1000; //Set the timer's tick to be 1000ms(1s) between each other.
            timer.Start(); //Start the timer.
        }*/

        //The code using since you using the application.
        private void Notebook_Shown(object sender, EventArgs e)
        {
            Time.Text = System.DateTime.Now.ToString(); //Show the time now in the Time Statuslabel.
            timer.Interval = 1000; //Set the timer's tick to be 1000ms(1s) between each other.
            timer.Start(); //Start the timer.

            string TextLength = Convert.ToString(txtMain.Text.Length); //Get the textlength of the editor.
            string LineLength = Convert.ToString(txtMain.Lines.Length); //Get the linelength of the editor.
            ��������toolStripStatusLabel.Text = "��������" + LineLength + "       ��������" + TextLength; //Show the textlength and linelength in the label.

            int index = txtMain.GetFirstCharIndexOfCurrentLine(); //Get the index line of the editor.
            string NowLineLength = Convert.ToString(txtMain.GetLineFromCharIndex(index) + 1); //Convert the index line of the editor and add 1 value to string,if you do not add 1,the value is 0.
            NowLinetoolStripStatusLabel.Text = "��ǰ�кţ�" + NowLineLength; //Show the index line in the label.

            string selectTextLength = Convert.ToString(txtMain.SelectedText.Length); //Convert the selectedtext in the editor to string.
            SelectTexttoolStripStatusLabel.Text = "��ѡ������" + selectTextLength; //Show the selectedtext in the label.

            /*Random random = new Random();����//��ѭ�������ʼ��
            int figure = random.Next(1, 5); //�������1��4�����е�����
            if (figure == 1) //Conditions.
            {
                MessageBox.Show("��ӭʹ��My Notebook 1.1.4�������������������\nʱ�����ۣ�Ը����һ��������Ҫ�����طꡣ\n����by Error", "Welcome");
            }
            if (figure == 2) //Conditions.
            {
                MessageBox.Show("��ӭʹ��My Notebook 1.1.4�������������������\n�ط��ʱ��ϣ������β���֧�����顣\n����by Error", "Welcome");
            }
            if (figure == 3) //Conditions.
            {
                MessageBox.Show("��ӭʹ��My Notebook 1.1.4�������������������\n��£�����Σ���ת�����ƣ�ʱ�����أ���Ъ�������ᡣ�����ʱ�䡣\n����by Error", "Welcome");
            }
            if (figure == 4) //Conditions.
            {
                MessageBox.Show("��ӭʹ��My Notebook 1.1.4�������������������\n��ʱ����Խ���ã���Խ�����⵽����ķ��ɡ�������Ϊ��һ����û�л��䣬�����Ǹ������ġ�\n����by Error", "Welcome");
            }*/

            Welcome welcome = new Welcome(); //Public the class of welcome form.
            welcome.ShowInTaskbar = false; //Let the form not show in the taskbar.
            welcome.ShowDialog(); //Show the form.
        }

        //Use the timer.
        private void timer_Tick(object sender, EventArgs e)
        {
            Time.Text = "��ǰʱ�䣺" + System.DateTime.Now.ToString(); //Use the timer to let the statuslabel called Time show the time now.
        }

        //Use the code since you enter the editor.
        private void txtMain_Enter(object sender, EventArgs e)
        {
            //No use.
        }

        //Use the code since the text in the editor changed.
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            string TextLength = Convert.ToString(txtMain.Text.Length); //Get the textlength of the editor.
            string LineLength = Convert.ToString(txtMain.Lines.Length); //Get the linelength of the editor.
            ��������toolStripStatusLabel.Text = "��������" + LineLength + "         ��������" + TextLength; //Show the textlength and linelength in the label.

            int index = txtMain.GetFirstCharIndexOfCurrentLine(); //Get the index line of the editor.
            string NowLineLength = Convert.ToString(txtMain.GetLineFromCharIndex(index) + 1); //Convert the index line of the editor and add 1 value to string,if you do not add 1,the value is 0.
            NowLinetoolStripStatusLabel.Text = "��ǰ�кţ�" + NowLineLength; //Show the index line in the label.
        }

        //Use the code since you click in the editor.
        private void txtMain_MouseDown(object sender, MouseEventArgs e)
        {
            int index = txtMain.GetFirstCharIndexOfCurrentLine(); //Get the index line of the editor.
            string NowLineLength = Convert.ToString(txtMain.GetLineFromCharIndex(index) + 1); //Convert the index line of the editor and add 1 value to string,if you do not add 1,the value is 0.
            NowLinetoolStripStatusLabel.Text = "��ǰ�кţ�" + NowLineLength; //Show the index line in the label.
        }

        //Use the code since your mouse up in the editor.
        private void txtMain_MouseUp(object sender, MouseEventArgs e)
        {
            string selectTextLength = Convert.ToString(txtMain.SelectedText.Length); //Convert the selectedtext in the editor to string.
            SelectTexttoolStripStatusLabel.Text = "��ѡ������" + selectTextLength; //Show the selectedtext in the label.
        }

        //Functional Block Diagram.
        private void ���ܿ�ͼtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            Function function = new Function(); //Public a class called function.
            function.ShowDialog(); //Show the form;
            function.ShowInTaskbar = false; //Let it not show in the taskbar.
        }


        //-------------------------------------------------------
        //This zone of code is the function of add spectial corn.
        //String1.
        private void button1_Click(object sender, EventArgs e)
        {
            txtMain.AppendText("?"); //Add the text after the text you edit in the editor.
        }

        //String2.
        private void button2_Click(object sender, EventArgs e)
        {
            txtMain.AppendText("��"); //Add the text after the text you edit in the editor.
        }

        //String3.
        private void button3_Click(object sender, EventArgs e)
        {
            txtMain.AppendText("��"); //Add the text after the text you edit in the editor.
        }

        //String4.
        private void button4_Click(object sender, EventArgs e)
        {
            txtMain.AppendText("��"); //Add the text after the text you edit in the editor.
        }

        //String5.
        private void button5_Click(object sender, EventArgs e)
        {
            txtMain.AppendText("��"); //Add the text after the text you edit in the editor.
        }

        //String6.
        private void button6_Click(object sender, EventArgs e)
        {
            txtMain.AppendText("��"); //Add the text after the text you edit in the editor.
        }

        //String7.
        private void button7_Click(object sender, EventArgs e)
        {
            txtMain.AppendText("��"); //Add the text after the text you edit in the editor.
        }

        //String8.
        private void button8_Click(object sender, EventArgs e)
        {
            txtMain.AppendText("��"); //Add the text after the text you edit in the editor.
        }

        //String9.
        private void button9_Click(object sender, EventArgs e)
        {
            txtMain.AppendText("��"); //Add the text after the text you edit in the editor.
        }

        //String10.
        private void button10_Click(object sender, EventArgs e)
        {
            txtMain.AppendText("��"); //Add the text after the text you edit in the editor.
        }

        //String11.
        private void button11_Click(object sender, EventArgs e)
        {
            txtMain.AppendText("��"); //Add the text after the text you edit in the editor.
        }

        //String12.
        private void button12_Click(object sender, EventArgs e)
        {
            txtMain.AppendText("��"); //Add the text after the text you edit in the editor.
        }

        //String13.
        private void button13_Click(object sender, EventArgs e)
        {
            txtMain.AppendText("��"); //Add the text after the text you edit in the editor.
        }

        //String14.
        private void button14_Click(object sender, EventArgs e)
        {
            txtMain.AppendText("��"); //Add the text after the text you edit in the editor.
        }

        //String15.
        private void button15_Click(object sender, EventArgs e)
        {
            txtMain.AppendText("��"); //Add the text after the text you edit in the editor.
        }

        //String16.
        private void button16_Click(object sender, EventArgs e)
        {
            txtMain.AppendText("��"); //Add the text after the text you edit in the editor.
        }

        //String17.
        private void button17_Click(object sender, EventArgs e)
        {
            txtMain.AppendText("��"); //Add the text after the text you edit in the editor.
        }

        //String18.
        private void button18_Click(object sender, EventArgs e)
        {
            txtMain.AppendText("��"); //Add the text after the text you edit in the editor.
        }

        //String19.
        private void button19_Click(object sender, EventArgs e)
        {
            txtMain.AppendText("��"); //Add the text after the text you edit in the editor.
        }

        //String20.
        private void button20_Click(object sender, EventArgs e)
        {
            txtMain.AppendText("��"); //Add the text after the text you edit in the editor.
        }

        //String21.
        private void button21_Click(object sender, EventArgs e)
        {
            txtMain.AppendText("��"); //Add the text after the text you edit in the editor.
        }

        //String22.
        private void button22_Click(object sender, EventArgs e)
        {
            txtMain.AppendText("��"); //Add the text after the text you edit in the editor.
        }

        //String23.
        private void button23_Click(object sender, EventArgs e)
        {
            txtMain.AppendText("��"); //Add the text after the text you edit in the editor.
        }

        //String24.
        private void button24_Click(object sender, EventArgs e)
        {
            txtMain.AppendText("��"); //Add the text after the text you edit in the editor.
        }

        //String25.
        private void button25_Click(object sender, EventArgs e)
        {
            txtMain.AppendText("��"); //Add the text after the text you edit in the editor.
        }

        //String26.
        private void button26_Click(object sender, EventArgs e)
        {
            txtMain.AppendText("��"); //Add the text after the text you edit in the editor.
        }

        //String27.
        private void button27_Click(object sender, EventArgs e)
        {
            txtMain.AppendText("��"); //Add the text after the text you edit in the editor.
        }

        //String28
        private void button28_Click(object sender, EventArgs e)
        {
            txtMain.AppendText("��"); //Add the text after the text you edit in the editor.
        }

        //String29
        private void button29_Click(object sender, EventArgs e)
        {
            txtMain.AppendText("��"); //Add the text after the text you edit in the editor.         
        }


        //-------------------------------------------------------
        //The code of view.
        //Toolbar's view.
        private void ��������ʾtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Get the view of it.
            toolStrip1.Visible = !toolStrip1.Visible; //Reverse selection.
            if (toolStrip1.Visible == true) //Conditions if it can be seen.
            {
                ��������ʾtoolStripMenuItem.Checked = true; //Set the checked of it true.
            }
            if (toolStrip1.Visible == false) //Conditions if it can be seen.
            {
                ��������ʾtoolStripMenuItem.Checked = false; //Set the checked of it false.
            }
        }

        //Special's view.
        private void ���������ʾtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Get the view of it.
            panel1.Visible = !panel1.Visible; //Reverse selection.
            if (panel1.Visible == true) //Conditions if it can be seen.
            {
                ���������ʾtoolStripMenuItem.Checked = true; //Set the checked of it true.
            }
            if (panel1.Visible == false) //Conditions if it can be seen.
            {
                ���������ʾtoolStripMenuItem.Checked = false; //Set the checked of it false.
            }
        }

        //Exchange's view.
        private void �����滻toolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = !panel2.Visible; //Get the view of it.
            if (panel2.Visible == true) //Reverse selection.
            {
                �����滻toolStripMenuItem.Checked = true; //Set the checked of it true.
            }
            if (panel2.Visible == false) //Conditions if it can be seen.
            {
                �����滻toolStripMenuItem.Checked = false; //Set the checked of it false.
            }
        }

        //Layout's view.
        private void ����toolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel3.Visible = !panel3.Visible; //Get the view of it.
            if (panel3.Visible == true) //Reverse selection.
            {
                ����toolStripMenuItem.Checked = true; //Set the checked of it true.
            }
            if (panel3.Visible == false) //Conditions if it can be seen.
            {
                ����toolStripMenuItem.Checked = false; //Set the checked of it false.
            }
        }

        //Search in panel.
        private void ����button_Click(object sender, EventArgs e)
        {
            string searchText = richTextBox1.Text; //Define a string data called searchText to read the text of SearchTextBox.
            txtMain.Focus();
            txtMain.Find(searchText); //Use the system function called Find on the editor to locate the text you want.
        }

        //Exchange in panel.
        private void �滻button_Click(object sender, EventArgs e)
        {
            txtMain.SelectedText = richTextBox2.Text; //Let the text selected in the editor exchanged to the text you input in the toolstriptextbox2.
        }

        //Text indent in panel.
        private void ��������button_Click(object sender, EventArgs e)
        {
            int textIndent = 30 * Convert.ToInt16(richTextBox3.Text); //Get the string you input in the textbox and convert it to int and multiply 30.
            txtMain.SelectionIndent = textIndent; //Set the text selection indent.
            txtMain.SelectionHangingIndent = textIndent - 2 * textIndent; //Let the line under the indent line do not move.
        }


        //-------------------------------------------------------
        //The code of download on Error's Github.
        //Download My Notebook software.
        private void �汾����toolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Error0227/My-Notebook-Package.git"); //Open the index.
        }

        //Error's Github.
        private void toolStripMenuItem43_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Error0227?tab=repositories"); //Open the index.
        }

        //Example.
        private void ʾ��toolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://error0227.github.io/My-Notebook-Package/My%20Notebook%201.2.6%20%E4%BD%BF%E7%94%A8%E7%A4%BA%E8%8C%83.mp4"); //Open the index.
        }
    }
}

//The application continues to updating����
//Hope you can have a happy mood everyday.
//Bye.