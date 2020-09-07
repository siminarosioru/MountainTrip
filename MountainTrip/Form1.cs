using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MountainTrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butonEnter_Click(object sender, EventArgs e)
        {
            if (checkBoxCort.Checked)
                MessageBox.Show("you checked the tent", "Output");
            if (checkBoxSacDeDormit.Checked)
                MessageBox.Show("you checked the sleeping bag", "Output");
            if (checkBoxIzopren.Checked)
                MessageBox.Show("you checked the isoprene mattress", "Output");
            if (checkBoxImbracaminte.Checked)
                MessageBox.Show("you checked the hiking clothes", "Output");
            if (checkBoxBocanci.Checked)
                MessageBox.Show("you checked the hiking boots", "Output");
            if (checkBoxBeteDrumetie.Checked)
                MessageBox.Show("you checked the hiking sticks");
        }

        private void linkCort_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=decathlon+cort&tbm=isch&ved=2ahUKEwiz3fvji8_rAhXO16QKHcvlDjoQ2-cCegQIABAA&oq=decathlon+cort&gs_lcp=CgNpbWcQAzICCAAyAggAMgIIADICCAAyAggAMgQIABAeMgQIABAeMgQIABAeMgQIABAeMgYIABAIEB5QmMgQWKXOEGCu0xBoAHAAeACAAbQBiAH2BJIBAzAuNJgBAKABAaoBC2d3cy13aXotaW1nwAEB&sclient=img&ei=EfxRX_OQEs6vkwXLy7vQAw&bih=578&biw=1280#imgrc=LRKjKjY6ev_D_M");
        }

        private void linkSacDeDormit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=decathlon+sac+de+dormit&sxsrf=ALeKk0011Zjagy64gAfINpQ9peSrTNF3IA:1599208451107&source=lnms&tbm=isch&sa=X&ved=2ahUKEwjdq5ndi8_rAhXIQUEAHflNBVEQ_AUoAXoECAwQAw&biw=1280&bih=578#imgrc=YWp7XCWkK0cV1M");
        }

        private void linkIzopren_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=saltea+izopren+decathlon&tbm=isch&ved=2ahUKEwib8d3Aks_rAhXSAewKHezZCYIQ2-cCegQIABAA&oq=decathlon+izopre&gs_lcp=CgNpbWcQARgBMgQIIxAnMgYIABAIEB5QtJwDWLScA2DhrgNoAHAAeACAAW-IAW-SAQMwLjGYAQCgAQGqAQtnd3Mtd2l6LWltZ8ABAQ&sclient=img&ei=HgNSX5vqG9KDsAfss6eQCA&bih=578&biw=1280#imgrc=Gb52RRGEEcputM");
        }

        private void linkImbracaminte_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=imbracaminte+decathlon&tbm=isch&ved=2ahUKEwi04unbks_rAhWHNewKHZSdARkQ2-cCegQIABAA&oq=imbracaminte+decathlon&gs_lcp=CgNpbWcQAzoGCAAQBxAeUKi8B1jv3Adg56sIaABwAHgAgAF6iAGIC5IBBDIuMTGYAQCgAQGqAQtnd3Mtd2l6LWltZ8ABAQ&sclient=img&ei=VwNSX_TaEIfrsAeUu4bIAQ&bih=578&biw=1280#imgrc=z25HCHMHauqQiM");
        }

        private void linkBocanciDeMunte_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=bocanci+de+munte+decathlon&tbm=isch&ved=2ahUKEwiowKjuus_rAhVK4qQKHYSjAsYQ2-cCegQIABAA&oq=bocanci+de+munte+decathlon&gs_lcp=CgNpbWcQAzIECAAQHjoGCAAQBxAeOgIIADoICAAQCBAHEB5Qz78rWPfbK2Cs4ytoAHAAeACAAZUBiAHLDpIBBDMuMTOYAQCgAQGqAQtnd3Mtd2l6LWltZ8ABAQ&sclient=img&ei=by1SX-jMHMrEkwWEx4qwDA&bih=578&biw=1280#imgrc=QhD_hyV7vuAnDM");
        }

        private void linkBeteDrumetie_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=bete+trekking+decathlon&tbm=isch&ved=2ahUKEwjD75Trus_rAhUDP-wKHdneAHIQ2-cCegQIABAA&oq=betedecathlon&gs_lcp=CgNpbWcQARgAMgYIABAHEB4yBggAEAcQHjIGCAAQBxAeMgYIABAHEB4yBggAEAcQHjoICAAQCBAHEB5Q-BBY7RRg6SVoAHAAeACAAZsBiAGiBJIBAzAuNJgBAKABAaoBC2d3cy13aXotaW1nwAEB&sclient=img&ei=aC1SX8ObNIP-sAfZvYOQBw&bih=578&biw=1280#imgrc=I7DXRsKFHZ4q7M");
        }

    }
}
