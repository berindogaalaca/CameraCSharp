using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CameraOrnek1
{
    public partial class Form2 : Form
    {
        Form1 form1 = null; //form1'e dönebilmek için tanımlıyoruz
        public Form2(Form1 form1)
        {
            this.form1 = form1;//parametre olarak gelen formu değişkene aktarıyoruz.
            InitializeComponent();
        }

        private void LinkedlnLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/kadir-furkan-güler-68b7b31b4/"); //LinkedIn profilini açıyoruz.
        }

        private void LinkedlnLink_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Open the Link", LinkedlnLink); //tooltipin nerede olduğunu görebilmek için LinkedlnLink şeklinde ekledik
        }

        private void LinkedlnLink2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/berin-do%C4%9Fa-alaca-25b2a01ba/");//LinkedIn profilini açıyoruz.
        }

        private void LinkedlnLink2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Open the Link", LinkedlnLink2); //tooltipin nerede olduğunu görebilmek için LinkedLink2 şeklinde ekledik
        }

        private void GitHubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/kadirfurkanguler");//GitHub profilini açıyoruz.
        }

        private void GitHubLink_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Open the Link", GitHubLink); //tooltipin nerede olduğunu görebilmek için GitHubLink şeklinde ekledik
        }

        private void GitHubLink2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/bdalaca"); //GitHub profilini açıyoruz.
        }

        private void GitHubLink2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Open the Link", GitHubLink2); //tooltipin nerede olduğunu görebilmek için GitHubLink2 şeklinde ekledik
        }

        private void CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();//Credit formunu kapatıyoruz.
            form1.Show();//Form1'i geri açıyoruz.
        }

        private void CLOSE_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Close", CLOSE); //tooltipin nerede olduğunu görebilmek için CLOSE şeklinde ekledik
        }
    }
}
