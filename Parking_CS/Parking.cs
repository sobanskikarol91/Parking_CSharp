﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_CS
{
    class Parking
    {
        int rzedy, kolumny, ile_zaparkowanych;
        //Font czcionka;
        //Text ile_zaparkowanych_txt, sr_masa_txt, sr_konie_mechaniczne_txt, sr_predkosc_txt, sr_zuzycie_benzyny_txt;
        //List<Text*> lista_tekstow; // przechowujemy wskaznik do wszystkich tekstow, aby szybko wykonywac na nich operacje za pomoca petli
        //vector<Slot> sloty;          // sloty w ktorych parkujemy samochody
        //Texture znak_tekstura;       // znak parkingu
        //Sprite znak_sprite;

        Parking(int rzedy, int kolumny, int kolumna_odstep, int rzad_odstep)
        {
            ile_zaparkowanych = 0;
            this.rzedy = rzedy;
            this.kolumny = kolumny;
            // tworzymy sloty do parkowania i dodajemy je do listy
            for (int r = 0; r < rzedy; r++)
                for (int k = 0; k < kolumny; k++)
                    sloty.push_back(Slot(rzad_odstep * r, kolumna_odstep * k));

            ustaw_teksty();
            ustaw_znak();
        }

        void ustaw_znak()
        {
           // znak_tekstura.loadFromFile("grafika/znak.png");
          //  znak_sprite.setTexture(znak_tekstura);
           // znak_sprite.setPosition(900, 0);
        }
/*
        void aktualizuj(RenderWindow* okno)
        {
            for (int i = 0; i < sloty.size(); i++)
            {
                bool klikniecie = sloty[i].pobierz_przycisk()->detekcja_klikniecia(okno);

                // jezeli nastapilo klikniecie na danym slocie
                if (klikniecie)
                {
                    if (sloty[i].czy_zajety())
                        wyparkuj(i);
                    else
                        zaparkuj(i);   // dodaj samochod na danym miejscu
                }
            }
        }
        */
        void uaktualnij_statystyki()
        {
            Parametry statystyki;

            // dodajemy wszystkie parametry samochodow do siebie
            for (int i = 0; i < sloty.size(); i++)
                if (sloty[i].czy_zajety()) // jezeli jest zajetyp rzez samochod do dodajemy parametry
                    statystyki += sloty[i].pobierz_samochod()->pobierz_parametry();

            if (ile_zaparkowanych > 0)
                statystyki /= ile_zaparkowanych;

            ile_zaparkowanych_txt.setString(
                "zaparkowane samochody: " + to_string(ile_zaparkowanych) + "/" + to_string(sloty.size()));
            sr_masa_txt.setString(
                "Sr. masa: " + to_string(statystyki.get_masa()));
            sr_predkosc_txt.setString(
                "Sr. predkosc: " + to_string(statystyki.get_predkosc()));
            sr_konie_mechaniczne_txt.setString(
                "Sr. km: " + to_string(statystyki.get_km()));
            sr_zuzycie_benzyny_txt.setString(
                "Sr. zuz. benz.: " + to_string(statystyki.get_zurz_benz()));
        }

        void ustaw_teksty()
        {
            // dodajemy referencje do tekstow dla listy
            lista_tekstow = vector < Text *>{ &ile_zaparkowanych_txt, &sr_masa_txt, &sr_konie_mechaniczne_txt, &sr_predkosc_txt, &sr_zuzycie_benzyny_txt };

            // wczytywanie czcionki
            if (!czcionka.loadFromFile("Czcionka/Arial.ttf"))
                cout << "Nie znaleziono czcionki!";

            // dzieki liscie mozemy wszystko szybko ustawic w petli dla kazdego tekstu
            for (int i = 0; i < lista_tekstow.size(); i++)
            {
                lista_tekstow[i]->setFont(czcionka);
                lista_tekstow[i]->setPosition(500, 10 + 50 * i);
                lista_tekstow[i]->setCharacterSize(20);
            }

            uaktualnij_statystyki();
        }

        // prywatne metody wykorzystujemy je tylko w klasie************************************************************************************************************
        void zaparkuj(int miejsce) // dodaj samochod do konkretnego slotu
        {
            Samochod* nowy_samochod;
            Ciezarowy ciezarowka;
            Osobowy osobowy;
            Sportowy sportowy;

            system("cls"); // czysci konsole
            cout << "Jaki samochod chcesz stworzyc?" << endl;
            cout << "1) Ciezarowy" << endl;
            cout << "2) Osobowy" << endl;
            cout << "3) Sportowy" << endl;

            // sprawdzamy wprowadzone dane uzytowniak gdy sa one dobre wybieramy odpowiednia opcje
            switch (sprawdz_poprawnosc_wyboru(1, 3))
            {
                case 1:
                    nowy_samochod = &ciezarowka;
                    break;
                case 2:
                    nowy_samochod = &osobowy;
                    break;
                default:
                    nowy_samochod = &sportowy;
            }

            // POLIMORFIZM!!! kazda z klas ma inaczej zaimplementowana metode virtualna stworz_samochod
            // w zaleznosci od tego na co mamy ustawiony wskaznik typu Ciezarowka, taka metoda zostanie wywolana
            nowy_samochod->StworzSamochod();

            sloty[miejsce].zaparkuj(*nowy_samochod);
            ile_zaparkowanych++;
            uaktualnij_statystyki();
        }

        void wyparkuj(int miejsce)
        {
            ile_zaparkowanych--;
            cout << "Wyparkuj samochod" << endl;
            sloty[miejsce].wyparkuj();
            uaktualnij_statystyki();
        }

        void draw(RenderTarget & target, RenderStates state) const // implementujemy metode odpowiedzialna za rysowanie na ekranie obiekty typu parking
{
	// rysuj miejsca parkingowe
	for (int i = 0; i<rzedy*kolumny; i++)
		target.draw(sloty[i]);

	// rysujemy wszystkie teksty na ekranie
	for (int i = 0; i<lista_tekstow.size(); i++)
		target.draw(* lista_tekstow[i]);

	// rysujemy znak;
	target.draw(znak_sprite);
}

}
}
