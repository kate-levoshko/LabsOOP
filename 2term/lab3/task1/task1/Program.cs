using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rang = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Valet", "Dama", "Korol", "Tuz"};
            List<Mast> koloda = new List<Mast>();

            #region
            Krest kcard0 = Koloda.CreateKrest();
            kcard0.setRang(rang[0]);
            koloda.Add(kcard0);
            Krest kcard1 = Koloda.CreateKrest();
            kcard1.setRang(rang[1]);
            koloda.Add(kcard1);
            Krest kcard2 = Koloda.CreateKrest();
            kcard2.setRang(rang[2]);
            koloda.Add(kcard2);
            Krest kcard3 = Koloda.CreateKrest();
            kcard3.setRang(rang[3]);
            koloda.Add(kcard3);
            Krest kcard4 = Koloda.CreateKrest();
            kcard4.setRang(rang[4]);
            koloda.Add(kcard4);
            Krest kcard5 = Koloda.CreateKrest();
            kcard5.setRang(rang[5]);
            koloda.Add(kcard5);
            Krest kcard6 = Koloda.CreateKrest();
            kcard6.setRang(rang[6]);
            koloda.Add(kcard6);
            Krest kcard7 = Koloda.CreateKrest();
            kcard7.setRang(rang[7]);
            koloda.Add(kcard7);
            Krest kcard8 = Koloda.CreateKrest();
            kcard8.setRang(rang[8]);
            koloda.Add(kcard8);
            Krest kcard9 = Koloda.CreateKrest();
            kcard9.setRang(rang[9]);
            koloda.Add(kcard9);
            Krest kcard10 = Koloda.CreateKrest();
            kcard10.setRang(rang[10]);
            koloda.Add(kcard10);
            Krest kcard11 = Koloda.CreateKrest();
            kcard11.setRang(rang[11]);
            koloda.Add(kcard11);
            Krest kcard12 = Koloda.CreateKrest();
            kcard12.setRang(rang[12]);
            koloda.Add(kcard12);

            Chirva ccard0 = Koloda.CreateChirva();
            ccard0.setRang(rang[0]);
            koloda.Add(ccard0);
            Chirva ccard1 = Koloda.CreateChirva();
            ccard1.setRang(rang[1]);
            koloda.Add(ccard1);
            Chirva ccard2 = Koloda.CreateChirva();
            ccard2.setRang(rang[2]);
            koloda.Add(ccard2);
            Chirva ccard3 = Koloda.CreateChirva();
            ccard3.setRang(rang[3]);
            koloda.Add(ccard3);
            Chirva ccard4 = Koloda.CreateChirva();
            ccard4.setRang(rang[4]);
            koloda.Add(ccard4);
            Chirva ccard5 = Koloda.CreateChirva();
            ccard5.setRang(rang[5]);
            koloda.Add(ccard5);
            Chirva ccard6 = Koloda.CreateChirva();
            ccard6.setRang(rang[6]);
            koloda.Add(ccard6);
            Chirva ccard7 = Koloda.CreateChirva();
            ccard7.setRang(rang[7]);
            koloda.Add(ccard7);
            Chirva ccard8 = Koloda.CreateChirva();
            ccard8.setRang(rang[8]);
            koloda.Add(ccard8);
            Chirva ccard9 = Koloda.CreateChirva();
            ccard9.setRang(rang[9]);
            koloda.Add(ccard9);
            Chirva ccard10 = Koloda.CreateChirva();
            ccard10.setRang(rang[10]);
            koloda.Add(ccard10);
            Chirva ccard11 = Koloda.CreateChirva();
            ccard11.setRang(rang[11]);
            koloda.Add(ccard11);
            Chirva ccard12 = Koloda.CreateChirva();
            ccard12.setRang(rang[12]);
            koloda.Add(ccard12);

            Pika pcard0 = Koloda.CreatePika();
            pcard0.setRang(rang[0]);
            koloda.Add(pcard0);
            Pika pcard1 = Koloda.CreatePika();
            pcard1.setRang(rang[1]);
            koloda.Add(pcard1);
            Pika pcard2 = Koloda.CreatePika();
            pcard2.setRang(rang[2]);
            koloda.Add(pcard0);
            Pika pcard3 = Koloda.CreatePika();
            pcard3.setRang(rang[3]);
            koloda.Add(pcard3);
            Pika pcard4 = Koloda.CreatePika();
            pcard4.setRang(rang[4]);
            koloda.Add(pcard4);
            Pika pcard5 = Koloda.CreatePika();
            pcard5.setRang(rang[5]);
            koloda.Add(pcard5);
            Pika pcard6 = Koloda.CreatePika();
            pcard6.setRang(rang[6]);
            koloda.Add(pcard6);
            Pika pcard7 = Koloda.CreatePika();
            pcard7.setRang(rang[7]);
            koloda.Add(pcard7);
            Pika pcard8 = Koloda.CreatePika();
            pcard8.setRang(rang[8]);
            koloda.Add(pcard8);
            Pika pcard9 = Koloda.CreatePika();
            pcard9.setRang(rang[9]);
            koloda.Add(pcard9);
            Pika pcard10 = Koloda.CreatePika();
            pcard10.setRang(rang[10]);
            koloda.Add(pcard10);
            Pika pcard11 = Koloda.CreatePika();
            pcard11.setRang(rang[11]);
            koloda.Add(pcard11);
            Pika pcard12 = Koloda.CreatePika();
            pcard12.setRang(rang[12]);
            koloda.Add(pcard12);

            Bubna bcard0 = Koloda.CreateBubna();
            bcard0.setRang(rang[0]);
            koloda.Add(bcard0);
            Bubna bcard1 = Koloda.CreateBubna();
            bcard1.setRang(rang[1]);
            koloda.Add(bcard1);
            Bubna bcard2 = Koloda.CreateBubna();
            bcard2.setRang(rang[2]);
            koloda.Add(bcard2);
            Bubna bcard3 = Koloda.CreateBubna();
            bcard3.setRang(rang[3]);
            koloda.Add(bcard3);
            Bubna bcard4 = Koloda.CreateBubna();
            bcard4.setRang(rang[4]);
            koloda.Add(bcard4);
            Bubna bcard5 = Koloda.CreateBubna();
            bcard5.setRang(rang[5]);
            koloda.Add(bcard5);
            Bubna bcard6 = Koloda.CreateBubna();
            bcard6.setRang(rang[6]);
            koloda.Add(bcard6);
            Bubna bcard7 = Koloda.CreateBubna();
            bcard7.setRang(rang[7]);
            koloda.Add(bcard7);
            Bubna bcard8 = Koloda.CreateBubna();
            bcard8.setRang(rang[8]);
            koloda.Add(bcard8);
            Bubna bcard9 = Koloda.CreateBubna();
            bcard9.setRang(rang[9]);
            koloda.Add(bcard9);
            Bubna bcard10 = Koloda.CreateBubna();
            bcard10.setRang(rang[10]);
            koloda.Add(bcard10);
            Bubna bcard11 = Koloda.CreateBubna();
            bcard11.setRang(rang[11]);
            koloda.Add(bcard11);
            Bubna bcard12 = Koloda.CreateBubna();
            bcard12.setRang(rang[12]);
            koloda.Add(bcard12);
            #endregion

            foreach (Mast c in koloda)
            {
                Console.WriteLine("{0} {1}", c.Name, c.getRang());
            }

            Console.ReadKey();
        }
    }
}





