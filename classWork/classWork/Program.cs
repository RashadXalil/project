string username ;
string password ;
string emeliyyat;
int mebleg = 0;
int ay = 0;
int faiz = 0;
int umumiOdenilecek = 0;
int ayliqOdenis=0;
int borc=0;
Console.WriteLine("\t\t\t\t\tWelcome to Bank!");
Console.WriteLine("\t\t\t\t----------------------------");
Console.WriteLine("\t\t\t\t\t   Login");

yenidenYoxla:
Console.Write("User name :");
username = Console.ReadLine();
Console.Write("Password :");
password = Console.ReadLine();


if (username == "vusal" && password == "12345")
{   
    basaQayit:
    Console.WriteLine("\t\t\t\t\tWelcome to " + username + "!");
    Console.WriteLine("\t\t\t\t----------------------------");
    Console.WriteLine();
    Console.WriteLine(" 1. Kretdit goturmek \n 2. Kredit odemek \n 3. hesabat");

    Console.Write("Edeceyiniz emeliyyati secin :");
    emeliyyat = Console.ReadLine();
    if (emeliyyat == "1")
    {
        Console.Write("Ay daxil edin: ");
        ay = Convert.ToInt32(Console.ReadLine());
        if (ay >= 0 && ay <= 12 && mebleg >= 0)
        {
            Console.Write("Mebleg daxil edin: ");
            mebleg = Convert.ToInt32(Console.ReadLine());
            umumiOdenilecek = mebleg * 12 / 100;
            umumiOdenilecek = mebleg + umumiOdenilecek;

            Console.WriteLine("Odenilecek mebleg: " + umumiOdenilecek);
            ayliqOdenis = umumiOdenilecek / ay;
            Console.WriteLine("Odenilecek mebleg: " + ayliqOdenis);
        }
        else if (ay >= 13 && mebleg > 0)
        {
            Console.Write("Mebleg daxil edin: ");
            mebleg = Convert.ToInt32(Console.ReadLine());
            umumiOdenilecek = mebleg * 18 / 100;
            umumiOdenilecek = mebleg + umumiOdenilecek;

            Console.WriteLine("Odenilecek mebleg: " + umumiOdenilecek);
            ayliqOdenis = umumiOdenilecek / ay;
            Console.WriteLine("Odenilecek mebleg: " + ayliqOdenis);
        }
        else
        {
            Console.WriteLine("Emeliyyat ugursuz oldu !");
            goto basaQayit;
        }
        Console.WriteLine("Razisiniz? \n 1.Beli \n 2.Xeyr");
        Console.Write("Emeliyyat: ");
        string sorgu = Console.ReadLine();

        if (sorgu == "1")
        {
            Console.WriteLine("Emeliyyat tamamlandi.");
            Console.Write("Indiki borcunuz:");
            Console.WriteLine(borc = umumiOdenilecek);
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            goto basaQayit;
        }
        else
        {
            Console.WriteLine("Emeliyyat ugursuz oldu!");
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            goto basaQayit;
        }

    }
    else if (emeliyyat == "2")
    {
        if (borc > 0)
        {
            Console.Write("Ayliq odenis: ");
            ayliqOdenis = Convert.ToInt32(Console.ReadLine());
        odemeEmeliyyati:
            Console.Write("Odemek ucun 1 basin: ");
            int odemek = Convert.ToInt32(Console.ReadLine());
            if (odemek == 1)
            {
                borc = borc - ayliqOdenis;
                int qaliq = Convert.ToInt32(ayliqOdenis);
                if (borc > 0)
                {
                    Console.WriteLine("Emeliyyat ugurlu oldu!");
                    Console.WriteLine("Qalan borc: " + borc);
                    Console.WriteLine("Qalan ay: " + (--ay));
                }
                else if (borc <= 0)
                {
                    Console.WriteLine("Sizin borcunuz bitdi ! Qaliq mebleg: " + (qaliq) );
                    Console.WriteLine("sizin borcunuz yoxdur");
                }
                goto basaQayit;
            }
            else
            {
                Console.WriteLine("Odene emeliyyati yanlisdir!");
                goto odemeEmeliyyati;
            }
        }
        else
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("Sizin borcunuz yoxdur!");
            Console.WriteLine("-------------------------");
            goto basaQayit;
        }
    }
    else if (emeliyyat == "3")
    {
        if (borc > 0)
        {

            Console.WriteLine("Borcunuz: " + borc);
            Console.WriteLine("Qalan ay: " + ay);
        }
        else
        {
            Console.WriteLine("Sizin borcunuz yoxdur!");
        }
        goto basaQayit;

    }
    else
    {
        Console.WriteLine("Emeliyat ugursuz oldu!");
        goto basaQayit;
    }
  
}
else
{
    Console.WriteLine("Bele istifadeci yoxdur !");
    Console.WriteLine("-------------------------");
    Console.WriteLine();
    goto yenidenYoxla;
}


