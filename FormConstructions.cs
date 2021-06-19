using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackerMan
{
    public partial class FormConstructions : Form
    {
        /// <summary>
        /// zmienna hakera
        /// </summary>
        Hacker hacker;
        public FormConstructions()
        {
            InitializeComponent();
        }
        public FormConstructions(Hacker hackerReference)
        {
            InitializeComponent();
            //przypisuje referencje hakera
            hacker = hackerReference;
        }

        /// <summary>
        /// funkcja wyłączająca okno budowania i konstrułowania obiektów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Visible = false;
        }
        /// <summary>
        /// funkcja odpowiedzialna za kupowanie stacji policji poprzez wciśnięcie przycisku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyPolice_Click(object sender, EventArgs e)
        {
            //koszty związane z budową policji
            int money = 450;
            //buduje police station jeśli mnie stać i odejmuje odpowiednią ilość pieniędzy
            if(hacker.GetMoney() >= money )
            {
                hacker.SetPolice(true);
                hacker.SetMoney(hacker.GetMoney() - money); 
                //zmieniam status checkboxa
                checkBoxPolice.Checked = true;
            }
           
        }
        /// <summary>
        /// funkcja odpowiedzialna za zakupienie bieżni poprzez wciśnięcie przycisku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyTrack_Click(object sender, EventArgs e)
        {
            //koszty związane z zakupem bieżni
            int money = 300;
            //kupuje bieżnie jeśli mnie stać i odejmuje odpowiednią ilość pieniędzy
            if (hacker.GetMoney() >= money)
            {
                hacker.SetTrack(true);
                hacker.SetMoney(hacker.GetMoney() - money);
                //zmieniam status checkboxa
                checkBoxTrack.Checked = true;
            }
            
        }
        /// <summary>
        /// funckja odpowiadająca za zrobienie firewalla poprzez wciśnięcie przycisku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonConstructFirewall_Click(object sender, EventArgs e)
        {
            //koszty związane z rowojem firewalla
            int money = 400;
            //rozwijam firewalla jeśli mnie stać i odejmuje odpowiednią ilość pieniędzy
            if (hacker.GetMoney() >= money)
            {
                hacker.SetFirewall(true);
                hacker.SetMoney(hacker.GetMoney() - money);
                //zmieniam status checkboxa
                checkBoxFirewall.Checked = true;
            }
            
        }
        /// <summary>
        /// funkcja odpoowiadająca za postawienie koparki bitcoin poprzez wciśnięcie przycisku 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonConstructBitconExcavator_Click(object sender, EventArgs e)
        {
            //koszty związane z postawieniem koparki
            int money = 550;
            //stawiam koparke jeśli mnie stać i odejmuje odpowiednią ilość pieniędzy 
            if (hacker.GetMoney() >= money)
            {
                hacker.SetBitcoinExcavator(true);
                hacker.SetMoney(hacker.GetMoney() - money);
                //zmieniam status checkboxa
                checkBoxBitcoinExcavator.Checked = true; 
            }
        }
        /// <summary>
        /// funckja pokazująca plusy i minusy zakupu policji po najechaniu myszką na przycisk
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyPolice_MouseHover(object sender, EventArgs e)
        {
            labelPoliceProsAndCons.Visible = true;
        }
        /// <summary>
        /// funckja chowająca plusy i minusy zakupu policji po najechaniu myszką na przycisk
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyPolice_MouseLeave(object sender, EventArgs e)
        {
            labelPoliceProsAndCons.Visible = false;
        }
        /// <summary>
        /// funckja pokazująca plusy i minusy zakupu bieżni po najechaniu myszką na przycisk
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyTrack_MouseHover(object sender, EventArgs e)
        {
            labelTrackProsAndCons.Visible = true;
        }
        /// <summary>
        /// funckja chowająca plusy i minusy zakupu bieżni po najechaniu myszką na przycisk
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyTrack_MouseLeave(object sender, EventArgs e)
        {
            labelTrackProsAndCons.Visible = false;
        }
        /// <summary>
        /// funckja pokazująca plusy i minusy rozwijania firewalla po najechaniu myszką na przycisk
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonConstructFirewall_MouseHover(object sender, EventArgs e)
        {
            labelFirewallProsAndCons.Visible = true;
        }
        /// <summary>
        /// funckja chowająca plusy i minusy rozwijania firewalla po najechaniu myszką na przycisk
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonConstructFirewall_MouseLeave(object sender, EventArgs e)
        {
            labelFirewallProsAndCons.Visible = false;
        }
        /// <summary>
        /// funckja pokazująca plusy i minusy zakupienia koparki po najechaniu myszką na przycisk
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonConstructBitconExcavator_MouseHover(object sender, EventArgs e)
        {
            labelBitcoinExavatorProsAndCons.Visible = true;
        }
        /// <summary>
        /// funckja chowająca plusy i minusy zakupienia koparki po najechaniu myszką na przycisk
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonConstructBitconExcavator_MouseLeave(object sender, EventArgs e)
        {
            labelBitcoinExavatorProsAndCons.Visible = false;
        }
    }
}
