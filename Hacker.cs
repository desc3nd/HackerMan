using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// klasa reprezentująca postać naszego hakera
/// </summary>
namespace HackerMan
{
    public class Hacker
    {
        #region zmienne
        // inteligencja hakera
        int inteligence = 1;
        // stamina hakera
        int stamina = 100;
        // liczba współpracowników
        int numberOfCooWorkers = 0;
        // liczba komputerów
        int numberOfComputers = 0;
        // liczba energii (prądu)
        int electricity = 100;
        //  liczba dostępnych pieniądzy
        int money = 1000;
        //liczba gwiazdek za hakowanie
        int stars = 0;
        //szanse na shakowanie
        int hackChances = 50;
        //budynki i konstrukcje hakera
        //policja
        bool police = false;
        //firewall
        bool firewall = false;
        //track
        bool track = false;
        //koparka bitcoinow
        bool bitcoinExcavator = false;
        #endregion
        /// funkcja zwracająca wartość inteligencji
        public int GetInteligence()
        {
            return inteligence;
        }
        /// funkcja zwracająca wartość staminy
        public int GetStamina()
        {
            return stamina;
        }
        /// funkcja zwracająca wartośći ilości pracowników
        public int GetNumberOfCooworkers()
        {
            return numberOfCooWorkers;
        }
        /// funkcja zwracająca wartość ilośći komputerów
        public int GetNumberOfComputers()
        {
            return numberOfComputers;
        }
        /// funkcja zwracająca wartość pieniedzy
        public int GetMoney()
        {
            return money;
        }
        /// funkcja zwracająca wartość gwiazdek
        public int GetStars()
        {
            return stars;
        }
        /// funkcja zwracająca wartość energii prądu
        public int GetElectricity()
        {
            return electricity;
        }
        ///funkcja zwracająca szanse na shakowanie
        public int GetHackChances()
        {
            return hackChances;
        }
        /// <summary>
        /// funkcja zwracająca stan budynków i konstrukcji - policji
        /// </summary>
        /// <returns></returns>
        public bool GetPolice()
        {
            return police;
        }
        /// <summary>
        /// funkcja zwracająca stan budynków i konstrukcji - firewall
        /// </summary>
        /// <returns></returns>
        public bool GetFirewall()
        {
            return firewall;
        }
        /// <summary>
        /// funkcja zwracająca stan budynków i konstrukcji - track
        /// </summary>
        /// <returns></returns>
        public bool GetTrack()
        {
            return track;
        }
        /// <summary>
        /// funkcja zwracająca stan budynków i konstrukcji - Bitcoin Excavator
        /// </summary>
        /// <returns></returns>
        public bool GetBitcoinExcavator()
        {
            return bitcoinExcavator;
        }
        /// <summary>
        /// funkcja ustawiająca wartość inteligencji
        /// </summary>
        /// <param name="value"></param>
        public void SetInteligence(int value)
        {
            inteligence = value;
        }
        /// <summary>
        /// funkcja ustawiająca wartość staminy
        /// </summary>
        /// <param name="value"></param>
        public void SetStamina(int value)
        {
            stamina = value;
        }
        /// <summary>
        /// funkcja ustawiająca ilość pracowników
        /// </summary>
        /// <param name="value"></param>
        public void SetNumberOfCooworkers(int value)
        {
            numberOfCooWorkers = value;
        }
        /// <summary>
        /// funkcja ustawiająca ilość komputerów
        /// </summary>
        /// <param name="value"></param>
        public void SetNumberOfComputers(int value)
        {
            numberOfComputers = value;
        }
        /// <summary>
        /// funkcja ustawiająca ilość pieniędzy
        /// </summary>
        /// <param name="value"></param>
        public void SetMoney(int value)
        {
            money = value;
        }
        /// <summary>
        /// funkcja ustawiająca ilość gwiazdek
        /// </summary>
        /// <param name="value"></param>
        public void SetStars(int value)
        {
            stars = value;
        }
        /// <summary>
        /// funkcja ustawiająca wartość prądu
        /// </summary>
        /// <param name="value"></param>
        public void SetElectricity(int value)
        {
            electricity = value;
        }
        /// <summary>
        /// funkcja ustawiająca wartość hackChances
        /// </summary>
        /// <param name="value"></param>
        public void SetHackChances(int value)
        {
            hackChances = value;
        }
        /// <summary>
        /// funckja ustawiająca wartość czy policja 
        /// </summary>
        /// <param name="value"></param>
        public void SetPolice(bool value)
        {
            police = value;
        }
        /// <summary>
        /// funckja ustawiająca wartość czy track  
        /// </summary>
        /// <param name="value"></param>
        public void SetTrack(bool value)
        {
            track = value;
        }
        /// <summary>
        /// funckja ustawiająca wartość czy firewall 
        /// <param name="value"></param>
        public void SetFirewall(bool value)
        {
            firewall = value;
        }
        /// <summary>
        /// funckja ustawiająca wartość czy Bitcoin excavator  
        /// </summary>
        /// <param name="value"></param>
        public void SetBitcoinExcavator(bool value)
        {
            bitcoinExcavator = value;
        }
    }
}
