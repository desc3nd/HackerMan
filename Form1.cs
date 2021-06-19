using System;
using System.Windows.Forms;
namespace HackerMan
{

    public partial class Form1 : Form
    {
        #region zmmienne
        /// <summary>
        /// tworze postać główną
        /// </summary>
        static Hacker haker = new Hacker();
        /// <summary>
        /// okno błędu
        /// </summary>
        NotEnoughSourceError notEnoughSourceError;
        /// <summary>
        /// zmienna obsługująca licznik zegara
        /// </summary>
        int counter = 1;
        /// <summary>
        /// zmienna odpowiadająca za imie gracza
        /// </summary>
        string name = "";
        /// <summary>
        /// zmienna odpowiadająca za szybkość zmian electricity (co ile sekund ma spadać jego ilość)
        /// </summary>
        int timeElectricityDrop = 10;
        /// <summary>
        /// tablica zmiennych odpowiadająca za inteligencje hakerów przeciwnika - deklaracja
        /// </summary>
        int[] oponentHackerIntelligence = new int[3];
        /// <summary>
        /// tablica zmiennych odpowiadająca za czas ataków hakerów oponentów
        /// </summary>
        int[] oponentHackerTimeAttack = new int[3];
        /// <summary>
        /// Okienko informujące o wygranej z hakerem
        /// </summary>
        FormWin formWin = new FormWin();
        /// <summary>
        /// okienko infromujące o przegranej z hakerem
        /// </summary>
        int timeStaminaToFill = 6;
        /// <summary>
        /// okienko infromujące o przegranej z hakerem
        /// </summary>
        FormLose formLose = new FormLose();
        /// <summary>
        /// zmienna random służąca do generowania liczb losowych by hakować z prawodopodbieństwem
        /// </summary>
        Random rand = new Random();
        /// <summary>
        /// okienko odpowiadające za informacje o porażce hakowania
        /// </summary>
        FormFailedHack formFailedHack = new FormFailedHack();
        /// <summary>
        /// okienko odpowiadające za informacje o konstrukcjach
        /// </summary>
        FormConstructions formConstructions = new FormConstructions(haker);
        /// <summary>
        /// zmienna odpowiadająca za czas ataku niespodziewanego hakera
        /// </summary>
        int timeSurpriseAttack = 180;
        /// <summary>
        /// zmienna odpowiadająca za czas wygrania na loterii
        /// </summary>
        int timeLotteryWon = 100;
        /// <summary>
        /// okienko odpowiadające za komunikat o wygranej na loterii
        /// </summary>
        FormLotteryWon formLotteryWon = new FormLotteryWon();
        /// <summary>
        /// okno odpowiadające za komunikat o ataku niespodziewanego hakera
        /// </summary>
        FormSurpriseAttack formSurpriseAttack = new FormSurpriseAttack();
        /// <summary>
        /// okienko końca gry - przegranej
        /// </summary>
        FormGameOver formGameOver = new FormGameOver();
        /// <summary>
        /// warunek wygranej - pokonanie 3 hakera
        /// </summary>
        bool defeatedThirdHacker = false;
        /// <summary>
        /// okienko informujące o wygranej gry
        /// </summary>
        FormGameWin formGameWin = new FormGameWin();
        #endregion
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// funkcja inicjalizuje zmienne inteligencji hakerów oponentów
        /// </summary>
        private void initializeoponentHackerIntelligence()
        {
            //inicjalizacja 1 hakera oponenta
            oponentHackerIntelligence[0] = 10;
            //2 haker oponent
            oponentHackerIntelligence[1] = 20;
            //3 haker oponent
            oponentHackerIntelligence[2] = 30;
        }
        /// <summary>
        /// funkcja inicjaluzujaca zmienne defaultowego czasu ataku hakerów
        /// </summary>
        private void initializeHackerTimeAttack()
        {
            //inicjalizacja czasów ataków - 5 min 1 haker
            oponentHackerTimeAttack[0] = 300;
            //inicjalizacja czasów ataków - 10 min 2 haker
            oponentHackerTimeAttack[1] = 600;
            //inicjalizacja czasów ataków - 15 min 3 haker
            oponentHackerTimeAttack[2] = 900;
        }

        /// <summary>
        /// funkcja włącza widoczność przypisu do guzika Buy Worker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyWorker_MouseHover(object sender, EventArgs e)
        {
            labelBuyWorkerProsAndCons.Visible = true;
        }
        /// <summary>
        /// funkcja wyłącza widoczność przypisu do guzika Buy Worker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyWorker_MouseLeave(object sender, EventArgs e)
        {
            labelBuyWorkerProsAndCons.Visible = false;
        }
        /// <summary>
        /// funkcja włącza widoczność przypisu do guzika Buy Computer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyComputer_MouseHover(object sender, EventArgs e)
        {
            labelBuyComputerProsAndCons.Visible = true;
        }
        /// <summary>
        /// funkcja wyłącza widoczność przypisu do guzika Buy Computer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyComputer_MouseLeave(object sender, EventArgs e)
        {
            labelBuyComputerProsAndCons.Visible = false;
        }
        /// <summary>
        /// funkcja włącza widoczność przypisu do guzika hack
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHack_MouseHover(object sender, EventArgs e)
        {
            labelHackProsAndCons.Visible = true;
        }
        /// <summary>
        /// funkcja wyłącza widoczność przypisu do guzika hack
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHack_MouseLeave(object sender, EventArgs e)
        {
            labelHackProsAndCons.Visible = false;
        }
        /// <summary>
        /// funkcja włącza widoczność przypisu do guzika Learn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLearn_MouseHover(object sender, EventArgs e)
        {
            labelLearnProsAndCons.Visible = true;
        }
        /// <summary>
        /// funkcja wyłącza widoczność przypisu do guzika learn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLearn_MouseLeave(object sender, EventArgs e)
        {
            labelLearnProsAndCons.Visible = false;
        }
        /// <summary>
        /// funkcja włącza widoczność przypisu do guzika Pay bills
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPayBills_MouseHover(object sender, EventArgs e)
        {
            labelPayBillsProsAndCons.Visible = true;
        }
        /// <summary>
        /// funkcja wyłącza widoczność przypisu do guzika Pay Bills
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPayBills_MouseLeave(object sender, EventArgs e)
        {
            labelPayBillsProsAndCons.Visible = false;
        }
        /// <summary>
        /// funkcja włącza widoczność przypisu do guzika Bribe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBribe_MouseHover(object sender, EventArgs e)
        {
            labelBribeProsAndCons.Visible = true;
        }
        /// <summary>
        /// funkcja wyłącza widoczność przypisu do guzika Bribe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBribe_MouseLeave(object sender, EventArgs e)
        {
            labelBribeProsAndCons.Visible = false;
        }
        /// <summary>
        /// funkcja odpowiadająca za logikę kupna pracownika (wcisniecia przyscisku)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyWorker_Click(object sender, EventArgs e)
        {
            //koszty związane z zakupem pracownika
            int money = 200;
            //bonusy związane z kupnem pracownika
            int inteligence = 1;
            // sprawdzam czy spełnione są warunki zasobów
            if (haker.GetMoney() >= 200)
            {
                //ustawiam aktualną ilość pieniedzy oraz inteligencji
                haker.SetMoney(haker.GetMoney() - money);
                haker.SetInteligence(haker.GetInteligence() + inteligence);
                //aktualizuje wyświetlaną ilość pieniedzy
                labelMoney.Text = haker.GetMoney().ToString();
                //aktualizuje wyświetlaną wartość inteligencji
                labelInteligence.Text = haker.GetInteligence().ToString();

            }
            else
            {
                //zapisuje referencje
                notEnoughSourceError = new NotEnoughSourceError();
                // wyświetlam okno informujące o braku zasobów
                notEnoughSourceError.Visible = true;
            }
        }
        /// <summary>
        /// funkcja odpowiadająca za logikę kupna komputera (wcisniecia przyscisku)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyComputer_Click(object sender, EventArgs e)
        {
            //koszty związane z zakupem komputera
            int money = 250;
            //bonusy związane z kupnem komputera
            int inteligence = 1;
            // sprawdzam czy spełnione są warunki zasobów
            if (haker.GetMoney() >= 250)
            {
                //ustawiam aktualną ilość pieniedzy oraz inteligencji
                haker.SetMoney(haker.GetMoney() - money);
                haker.SetInteligence(haker.GetInteligence() + inteligence);
                //aktualizuje wyświetlaną ilość pieniedzy
                labelMoney.Text = haker.GetMoney().ToString();
                //aktualizuje wyświetlaną wartość inteligencji
                labelInteligence.Text = haker.GetInteligence().ToString();

            }
            else
            {
                //zapisuje referencje
                notEnoughSourceError = new NotEnoughSourceError();
                // wyświetlam okno informujące o braku zasobów
                notEnoughSourceError.Visible = true;
            }
        }
        /// <summary>
        /// funkcja odpowiadająca za logikę hakowania (wcisniecia przyscisku)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHack_Click(object sender, EventArgs e)
        {

            //koszty związane z hakowaniem
            int stamina = 40;
            int star = 1;
            //bonusy związane z hakowaniem
            int money = 50;
            // sprawdzam czy spełnione są warunki zasobów
            if (haker.GetStamina() >= stamina)
            {
                //sprawdzam czy hack  sie udał i jeżeli tak to ustawiam wartość pieniędzy
                if(rand.Next(101) < haker.GetHackChances())
                {
                    haker.SetMoney(haker.GetMoney() + money);     
                }
                //jeżeli nie to wyswietlam komunikat o nie udanym haku
                else
                {
                   formFailedHack.Visible = true;
                }
                //ustawiam aktualną ilość oraz staminy i gwiazd
                haker.SetStamina(haker.GetStamina() - stamina);
                haker.SetStars(haker.GetStars() + star);
                //aktualizuje wyświetlaną ilość pieniedzy staminy i gwiazd
             
                labelMoney.Text = haker.GetMoney().ToString();
                labelStars.Text = haker.GetStars().ToString();
                progressBarStamina.Value = haker.GetStamina();
            }
            else
            {
                //zapisuje referencje
                notEnoughSourceError = new NotEnoughSourceError();
                // wyświetlam okno informujące o braku zasobów
                notEnoughSourceError.Visible = true;
            }
        }
        /// <summary>
        /// funkcja odpowiadająca za logikę uczenia sie (wcisniecia przyscisku)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLearn_Click(object sender, EventArgs e)
        {
            //koszty związane z uczeniem sie
            int stamina = 20;
            int money = 20;
            //benefity związane z uczeniem sie
            int hackChances = 5;
            // sprawdzam czy spełnione są warunki zasobów
            if (haker.GetStamina() >= stamina)
            {
                //ustawiam aktualną ilość pieniedzy oraz staminy oraz prawdopodobieństwa udania sie hakowania
                haker.SetMoney(haker.GetMoney() - money);
                haker.SetStamina(haker.GetStamina() - stamina);
                haker.SetHackChances(haker.GetHackChances() + hackChances);
                //aktualizuje wyświetlaną ilość pieniedzy i staminy oraz hackChances
                labelMoney.Text = haker.GetMoney().ToString();
                progressBarStamina.Value = haker.GetStamina();
                labelhackChances.Text = haker.GetHackChances().ToString();
            }
            else
            {
                //zapisuje referencje
                notEnoughSourceError = new NotEnoughSourceError();
                // wyświetlam okno informujące o braku zasobów
                notEnoughSourceError.Visible = true;
            }
        }
        /// <summary>
        /// funkcja odpowiadająca za logikę placenia podatków za prąd (wcisniecia przyscisku)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPayBills_Click(object sender, EventArgs e)
        {

            //koszty związane płaceniem rachunków
            int money = 20;
            //benefity zwiazane z placeniem
            int electricity = 100;
            // sprawdzam czy spełnione są warunki zasobów
            if (haker.GetMoney() >= money)
            {
                //ustawiam aktualną ilość pieniedzy oraz prądu 
                haker.SetMoney(haker.GetMoney() - money);
                haker.SetElectricity(electricity);
                //aktualizuje wyświetlaną ilość pieniedzy i prądu
                labelMoney.Text = haker.GetMoney().ToString();
                progressBarElectricity.Value = haker.GetElectricity();
            }
            else
            {
                //zapisuje referencje
                notEnoughSourceError = new NotEnoughSourceError();
                // wyświetlam okno informujące o braku zasobów
                notEnoughSourceError.Visible = true;
            }
        }
        /// <summary>
        /// funkcja odpowiadająca za logikę dawania łapówki (wcisniecia przyscisku)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBribe_Click(object sender, EventArgs e)
        {   
            //koszty związane łapówką
            int money = 100;
            //benefity zwiazane z placeniem
            int star = 0;
            // sprawdzam czy spełnione są warunki zasobów
        
            if (haker.GetMoney() >= money)
            {
                //ustawiam aktualną ilość pieniedzy oraz gwiazd
                haker.SetMoney(haker.GetMoney() - money);
                haker.SetStars(star);
                //aktualizuje wyświetlaną ilość pieniedzy i gwiazd
                labelMoney.Text = haker.GetMoney().ToString();
                labelStars.Text = haker.GetStars().ToString();
            }
            else
            {
                //zapisuje referencje
                notEnoughSourceError = new NotEnoughSourceError();
                // wyświetlam okno informujące o braku zasobów
                notEnoughSourceError.Visible = true;
            }
        }
        /// <summary>
        /// wywoływanie funkcji obsługugiwanej przez wątel elementu timer count
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerCounter_Tick(object sender, EventArgs e)
        {
            //zmienne zmieniające wartości hakera
            int electricity = 10;
            int intelligence = 2;
            //zmienna czasowa inkrementowana
            counter++;
            //logika związana z obsługą zdarzeń co jakiś okres czasu
            if (counter % timeElectricityDrop == 0)
            {
                //ustawiam nową wartość electricity
                haker.SetElectricity(haker.GetElectricity() - electricity);
                //aktualnizuje wyświetlnienie electricity
                progressBarElectricity.Value = haker.GetElectricity();
            }
            //3 ataki  hakera
            for(int i=0; i<oponentHackerIntelligence.Length; i++)
            {
                if(counter%oponentHackerTimeAttack[i] == 0)
                {   //sprawdzam czy wartość inteligencji hakera oponenta jest większa od mojej
                    if(oponentHackerIntelligence[i] > haker.GetInteligence())
                    {
                        //jeżeli moja wartość inteligencji jest mniejsza i mam więcej niż 2 to usuwam
                        if(haker.GetInteligence() > intelligence)
                        haker.SetInteligence(haker.GetInteligence() - intelligence);
                        //włączam okienko informujące o przegranej
                        formLose.Visible = true;
                    }
                    //wlaczam okno inforumjące o wygranej
                    else
                    {
                        //sprawdzam czy jest to ostatni haker
                        if(i == 3)
                        {
                            //włączam warunek wygranej
                            defeatedThirdHacker = true;
                        }
                        //wyłączam hakera
                        oponentHackerTimeAttack[i] = 999999;
                        //wlączam okno dialogowe o zwycięstwie
                        formWin.Visible = true;
                    }
                }
            }
            // aktualizuje stan staminy co timeStaminaToFill
            if(counter % timeStaminaToFill == 0)
            {
                //zmienna dopełniająca ilość staminy
                int staminaFill = 10;
                //90 ilość minimalnej by dodać
                if(haker.GetStamina()<=90)
                {
                    //aktualizacja staminy hakera i wyświetlającego paska
                    haker.SetStamina(haker.GetStamina() + staminaFill);
                    progressBarStamina.Value = haker.GetStamina();
                }
            }
            //inicjaluzuje niespodziewany atak hakera 
            if(counter % timeSurpriseAttack == 0)
            {
                //kasa stracona po ataku hakera
                int money = 150;
                //jeżeli nie mam firewalla to trace pieniądze
                if(haker.GetFirewall() == false)
                {
                    haker.SetMoney(haker.GetMoney() - money);
                    //odświeżam wartość pieniędzy
                    labelMoney.Text = haker.GetMoney().ToString();
                }
                //albo haker zaatakuje 40 sek szybciej albo pozniej następnym razem
                if (rand.Next(1) == 1)
                {
                    //ustawienie czasu nowego ataku
                    timeSurpriseAttack += 40;
                }
                else
                    timeSurpriseAttack -= 40;
                //wyświetlam okno z komunikatem o ataku
                formSurpriseAttack.Visible = true;
            }
            // jezeżeli mamy kopalnie bitcoinów to zarabiamy
            if(haker.GetBitcoinExcavator() == true )
            {
                //zmienna inicjalizująca co jaki czas mamy zarabiać
                int timeToEarnMoney = 30;
                //zmienna inicjalizująca ile mamy zarabiać
                int money = 30;
                if(counter % timeToEarnMoney == 0)
                {
                    //ustawienie nowej kwoty pieniedzy
                    haker.SetMoney(haker.GetMoney() + money);
                    //odświeżam wartość pieniędzy
                    labelMoney.Text = haker.GetMoney().ToString();
                }
            }
            //sprawdzam czy mam bieżnie jeżeli tak to mam co sekunde max stamine
            if(haker.GetTrack() == true)
            {
                //zmienna określająca nową wartość staminy
                int staminaMax = 100;
                //inicjalizuje nową wartość staminy dla hakera i na labelu
                haker.SetStamina(staminaMax);
                progressBarStamina.Value = staminaMax;
            }
            //sprawdzam czy mam policje jeżeli tak to mam co sekunde zerowane gwiazki
            if (haker.GetPolice() == true)
            {
                //zmienna określająca nową ilośc gwiazdek
                int stars = 0;
                //inicjalizuje nową ilość gwiazdek i wyświetlam
                haker.SetStars(stars);
                labelStars.Text = haker.GetStars().ToString();
            }
            //sprawdzam czy wygrałem na loterii
            if(counter == timeLotteryWon)
            {
                //zmienna określająca wartość wygranej na loterii
                int money = 150;
                //inicjaluzje nową wartość pieniędzy
                haker.SetMoney(haker.GetMoney() + money);
                //aktualizuje labelMoney
                labelMoney.Text = haker.GetMoney().ToString();
                //wyświetlam okienko informujące o wygranej na loterii
                formLotteryWon.Visible = true;
            }
            ///sprawdzam warunek przegranej
            if(haker.GetElectricity() <=0 || haker.GetStars() >=4)
            {
                //wyświetlam komunikat o przegranej
                formGameOver.Visible = true;
                //wyłączam funkcjonalność i timer
                timerCounter.Stop();
            }
            //sprawdzam warunek wygranej
            if(haker.GetHackChances()>=100 && defeatedThirdHacker == true)
            {
                //wyświetlam komunikat o wygranej
                formGameWin.Visible = true;
                //wyłączam funkcjonalności i timer
                timerCounter.Stop();
            }
            ///aktualizuje zasób pieniędzy
            labelMoney.Text = haker.GetMoney().ToString();
        }
        /// <summary>
        /// funkcja rozpoczynająca odliczanie zegara i start gry oraz wyłączająca panel startu a także wywołująca funkcje inicjaluzjące zmienne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            //włączenie zegara
            timerCounter.Start();
            //wyłączenie panelu startu
            panelStart.Visible = false;
            //zapisanie imienia gracza
            name = textBoxName.Text;
            //inicjalizacja zmiennych inteligencji ataku hakerów
            initializeoponentHackerIntelligence();
            //inicjalizacja zmiennych czasu ataku hakerów
            initializeHackerTimeAttack();
            //inicjalizacja zmiennej określającej czas wygrania na loterii
            timeLotteryWon = rand.Next(1, 1000);
            timeSurpriseAttack = rand.Next(1, 500);
        }
        /// <summary>
        /// funkcja zmieniająca tekst pierwotny w textboxie Name  w panelu start
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxName_Click(object sender, EventArgs e)
        {
            //czyszczenie tekstu
            textBoxName.Clear();
        }
        /// <summary>
        ///funkcja odpowiadająca za zmiane ustawień gry na medium 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonMedium_CheckedChanged(object sender, EventArgs e)
        {
            //zmiana szybkości spadania prądu
            timeElectricityDrop = 5;
            //zmiana szybkości przyjścia hakerów
            oponentHackerTimeAttack[0] = 240; // 4 min
            oponentHackerTimeAttack[1] = 540; //9 min
            oponentHackerTimeAttack[2] = 840; //14 min
        }
        /// <summary>
        /// funkcja przywracająca ustawienia default którym jest tryb łatwy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonEasy_CheckedChanged(object sender, EventArgs e)
        {
            //zmiana szybkosci spadania prądu
            timeElectricityDrop = 9;
            //zmiana szybkości przyjścia hakerów
            oponentHackerTimeAttack[0] = 300; // 5 min
            oponentHackerTimeAttack[1] = 600; //10 min
            oponentHackerTimeAttack[2] = 900; //15 min
        }
        /// <summary>
        /// funkcja odpowiadająca za zmiane ustawień gry na hard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonHard_CheckedChanged(object sender, EventArgs e)
        {
            //zmiana szybkosci spadania prądu
            timeElectricityDrop = 3;
            //zmiana szybkości przyjścia hakerów
            oponentHackerTimeAttack[0] = 180; // 3 min
            oponentHackerTimeAttack[1] = 480; //8 min
            oponentHackerTimeAttack[2] = 780; //13 min
        }
        /// <summary>
        /// funkcja odpowiadająca za otwarcie okna z konstrukcjami po kliknięciu buttonConstruct
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonConstruct_Click(object sender, EventArgs e)
        {
            formConstructions.Visible = true;
        }
    }

}
