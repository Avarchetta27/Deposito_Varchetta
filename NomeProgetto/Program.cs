using System;


class Program
{
    static void Main(string[] args)
    {
    //Esercizio_1();
    //Esercizio_2();
    //Esercizio_3();
    //Esercizio_4();
    //Esercizio_5();
    //Esercizio_6();
    //Esercizio_7();
    //Esercizio_8();
    //Esercizio_9();
    //Esercizio_10();
    //Esercizio_11();
    //Esercizio_12();
    //Esercizio_13();
    //Esercizio_14();
    //Esercizio_15();
    //Esercizio_16();
    //Esercizio_17();
    //Esercizio_18();
    //Esercizio_19();
    Esercizio_20();
    Esercizio_21();
    Esercizio_22();


    }


    static void Esercizio_1()
    {
        const double pass = 0000;
        int cont = 0;

        do {
            Console.WriteLine("Inserisci una pass : \n");
            double inserimento = double.Parse(Console.ReadLine());

            if(inserimento == pass)
            {
                 Console.WriteLine("La pass è corretta \n");
                 break;
            }

            Console.WriteLine("La pass non è corretta, riprova! \n");
            cont ++;

        }
        while (cont < 3);

        Console.WriteLine("Tentativi terminati \n");
    }
    static void Esercizio_2()
    {
        int somma = 0;
        int insert;
        do
        {
            Console.WriteLine("Inserisci un numero intero : \n");
            insert = int.Parse(Console.ReadLine());
            somma += insert;

        }
        while (insert != 0);
        Console.WriteLine(somma);
    }
    static void Esercizio_3()
    {
        double risultato = 0;
        double insert_1;
        double insert_2;
        string operazione;
        string scelta;


        do
        {
            Console.WriteLine("Inserisci il primo numero \n");
            insert_1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci il secondo numero \n");
            insert_2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Scegli l'operazione che vuoi eseguire: \n");
            operazione = Console.ReadLine();

            switch(operazione)
            {

                case "+":
                risultato = insert_1 + insert_2;
                Console.WriteLine($"Il risultato è {risultato} \n Vuoi continuare");
                break;

                case "-":
                risultato = insert_1 - insert_2;
                Console.WriteLine($"Il risultato è {risultato} \n Vuoi continuare");
                break;
                
                case "*":
                risultato = insert_1 * insert_2;
                Console.WriteLine($"Il risultato è {risultato} \n Vuoi continuare");
                break;

                case "/":
                risultato = insert_1 / insert_2;
                Console.WriteLine($"Il risultato è {risultato} \n Vuoi continuare");
                break;

                default :
                Console.WriteLine("Operazione invalida \n Vuoi continuare");
                break;
               }

            scelta = Console.ReadLine();
            if (scelta == "Y")
                continue;
                     else
                        break;


        }
        while (true);

    }
    static void Esercizio_4()
    {
        Console.WriteLine("Inserisci una stringa : \n");
        string s = Console.ReadLine();
        string confronto = "aeiouAEIOU";
        int count=0;

        foreach(char c in s)
        {
            if( confronto.Contains(c))
            count ++;
        }

        Console.WriteLine("Le vocali sono : " + count + "\n");
    }
    static void Esercizio_5()
    {
         const int max_len= 8;
         bool is_upper=false;
         bool is_digit=false;
         Console.WriteLine("Inserisci una pass : \n");
         string s = Console.ReadLine();
        
         


         foreach(char c in s)
        {
            if(char.IsUpper(c))
            is_upper = true;
            
            if (char.IsDigit(c))
            is_digit=true;
            
        }

        if (s.Length > max_len && is_digit && is_upper &&  !s.StartsWith(" ") && !s.EndsWith(" "))
        Console.WriteLine("La pass è valida \n");
        else
        Console.WriteLine("La pass non è valida \n");
    

    }
    static void Esercizio_6()

    {
         Console.WriteLine("Inserisci una parola : \n");
         string s = Console.ReadLine();
         string[] appoggio= s.Split(' ');
         int conta_parole=0;
         int conta_caratteri=0;
         int conta_spazi=0;
         int conta_segni=0;

         foreach(char c in s)
        {
            if(char.IsLetter(c))
            conta_caratteri++;
            else if (char.IsPunctuation(c))
            conta_segni++;
            else if (char.IsWhiteSpace(c))
            conta_spazi++;
        }

          foreach(string s2 in appoggio)
        {
            if( s2 != "")
            conta_parole ++;
        }


        Console.WriteLine("parole: " + conta_parole + "\n");
        Console.WriteLine("caratteri: " + conta_caratteri + "\n");
        Console.WriteLine("segni: " + conta_segni + "\n");
        Console.WriteLine("spazi: " + conta_spazi + "\n");


        

    }
    static void Esercizio_7()
    {
        Console.WriteLine("Ciao,inserisci il tuo nome: \n");
        string s = Console.ReadLine();
        StampaSaluto(s);

    }
    static void Esercizio_8()
    {
        Console.WriteLine("Inserisci un numero \n");
        int n = int.Parse(Console.ReadLine());
        if (VerificaPari(n))
        Console.WriteLine("Il numero è pari \n");
        else
        Console.WriteLine("Il numero è dispari \n");
    }
    static void Esercizio_9()
    {
        Console.WriteLine("Inserisci la base della potenza : \n");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Inserisci la potenza : \n");
        int m = int.Parse(Console.ReadLine());
        int risultato = CalcolaPotenza(n,m);
        Console.WriteLine("Il risultato è  : \n" + risultato + "\n");
    }
    static void Esercizio_10()
    {
        Console.WriteLine("Inserisci un numero :\n");
        int inserimento = int.Parse(Console.ReadLine());
        Raddoppia(ref inserimento);
        Console.WriteLine("Il numero raddoppiato è :\n" + inserimento);
        Console.WriteLine("Inserisci il secondo numero numero :\n");
        int inserimento2 = int.Parse(Console.ReadLine());
        int quoziente,resto;
        Dividi(inserimento,inserimento2,out quoziente,out resto);
        Console.WriteLine($"Quoziente : {quoziente}\nResto : {resto}");
    }
    static void Esercizio_11()
    {
        int ContaVocali,ContaConsonanti,ContaSpazi;
        Console.WriteLine("Inserisci una parola :\n");
        string inserimento = Console.ReadLine();
        AnalizzaParola(inserimento,out ContaVocali,out ContaConsonanti,out ContaSpazi);
        Console.WriteLine($"le vocali sono :{ContaVocali}\nle consonanti sono : {ContaConsonanti}\ni spazi sono : {ContaSpazi}\n");

    }
    static void Esercizio_12()
    {
        double PunteggioMedio =0;
        int PunteggioTotale = 0 ;
       
        Console.WriteLine("Inserisci un bonus  :\n");
        int bonus = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Inserisci il primo punteggio  :\n");
        int inserimento = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Inserisci il secondo punteggio  :\n");
        int inserimento2 = int.Parse(Console.ReadLine());
       
        Console.WriteLine("Inserisci il terzo punteggio  :\n");
        int inserimento3 = int.Parse(Console.ReadLine());
        
        AggiornaPunteggio(bonus,ref inserimento,ref inserimento2,ref inserimento3,out PunteggioTotale,out PunteggioMedio);
        
        Console.WriteLine($"Punteggio Totale  : {PunteggioTotale}\n" + $"Punteggio Medio su 3 turni :{PunteggioMedio} \n");
    }
    static void Esercizio_13()
    {
        string Studente = "Antonio";
        int voto1=6;
        int voto2=6;
        double votomedio;
        bool ispromoted;
        ElaboraStudente(Studente,ref voto1,ref voto2,out votomedio,out ispromoted);
        string frase;
        if(ispromoted)
        frase = " è ";
        else
        frase = " non è ";
        Console.WriteLine($"il voto medio è  {votomedio} :\nLo studente " + frase + " promosso");
    }
    static void Esercizio_14()
    {
        Console.WriteLine("Inserisci il giorno  :\n");
        int giorno = int.Parse(Console.ReadLine());
        Console.WriteLine("Inserisci il mese  :\n");
        int mese = int.Parse(Console.ReadLine());
        Console.WriteLine("Inserisci l'anno  :\n");
        int anno = int.Parse(Console.ReadLine());
        AggiustaData(ref giorno,ref mese,ref anno);
        Console.WriteLine($"{giorno}-{mese}-{anno}");
    }
    static void Esercizio_15()
    { 
        int a=1,b=2,c=3;
        double d=4.4,e=5.5;
        Console.WriteLine($"La somma tra {a} e {b} è : " +Somma(a,b) + "\n");
        Console.WriteLine($"La somma tra {a} {b} {c} è : " +Somma(a,b,c) + "\n");
        Console.WriteLine($"La somma tra {d} e {e} è : " +Somma(d,e) + "\n");
    }
    static void Esercizio_16()
    {
        string prova="Ciao";
        char c = 'i';
        bool contavocali = false;
        Analizza(prova);
        Console.WriteLine($"Verifica {c} in {prova} " + Analizza(prova,c) + "\n");
        Console.WriteLine($"Conta vocali o consonanti :" + Analizza(prova,contavocali));
    }
    static void Esercizio_17()
    {
        Console.WriteLine("Lancio i dadi : \n");
        Random rnd = new Random();
        int random = rnd.Next(1,6);
        int random2 = rnd.Next(1,6);

        Console.WriteLine($"i dati lanciati sono {random} e {random2}, la loro somma è{random+random2}\n");
    
    }
    static void StampaSaluto( String s)
    {
        Console.WriteLine("Ciao " + s);
    }
    static bool VerificaPari(int n)
    {
        if(n%2 == 0)
        return true;
        else
        return false;
    }
    public static  int CalcolaPotenza( int bs, int esp)
    {
        int result = 1;
        for (int i = 0; i < esp; i++)
        {
            result *= bs;
        }
        return result;

    }
    public static void Raddoppia(ref int n)
    {
        n *= 2;
    }
    public static void AggiustaData(ref int giorno,ref int mese,ref int anno)
    {
        if (giorno > 30)
        {
        mese += 1;
        giorno =1;
        }

        if (mese > 12)
        {
        anno += 1;
        mese = 1;
        }
    }
    public static void Dividi(int n1, int n2,out int quoziente , out int resto)
    {
        quoziente = n1 / n2;
        resto = n1 % n2 ;
    }
    public static void AnalizzaParola(string s, out int ContaVocali, out int ContaConsonanti, out int ContaSpazi)
    {
        ContaVocali = 0;
        ContaConsonanti = 0;
        ContaSpazi = 0;

        foreach(char c in s.ToLower())
        {
            if( "aeiou".Contains(c))
            ContaVocali ++;
            else if (char.IsLetter(c))
            ContaConsonanti ++;
            else if (char.IsWhiteSpace(c))
            ContaSpazi++;
        }
    }
    public static void AggiornaPunteggio(int bonus, ref int punteggio, ref int punteggio2, ref int punteggio3,
    out int PunteggioTotale, out double PunteggioMedio)
    {
        punteggio += bonus;
        punteggio2 += bonus;
        punteggio3 += bonus;

        PunteggioTotale = punteggio + punteggio2 + punteggio3;

        PunteggioMedio = PunteggioTotale / 3.0 ;
;
    }
    public static void ElaboraStudente(string Nome, ref int Voto1, ref int Voto2, out double VotoMedio,out bool IsPromosso)

    {
        IsPromosso=false;
        VotoMedio = (Voto1+Voto2)/2;
        if(VotoMedio >= 6)
        IsPromosso = true;
    }
    public static int Somma(int a,int b)
    {
        return a+b;
    }
    public static int Somma(int a,int b,int c)
    {
        return a+b+c;
    }
    public static double Somma(double a,double b)
    {
        return a+b;
    }
    public static void Analizza(string testo)
    {
        
        int lunghezza =testo.Length;
        int contaconsonanti;
        int contavocali;
        int contaspazi;
        AnalizzaParola(testo,out contavocali,out contaconsonanti,out contaspazi);

        Console.WriteLine($"La lunghezza del testo senza spazi è : {lunghezza-contaspazi}");
    }
    public static int Analizza(string testo,char carattere)
    {
        int count=0;
        foreach (char c in testo)
        {
            if(c == carattere)
            count++;
        }
        return count;
    }
    public static int Analizza(string testo,bool contaVocali)
    {
        if (contaVocali){
        return Analizza(testo.ToLower(),'a') + Analizza(testo.ToLower(),'e') + Analizza(testo.ToLower(),'i') +
        Analizza(testo.ToLower(),'o') + Analizza(testo.ToLower(),'u');  
        }
        else
        {
            int contaconsonanti;
            int contavocali;
            int contaspazi;
            AnalizzaParola(testo,out contavocali,out contaconsonanti,out contaspazi);
            return contaconsonanti;

        }
       
       

    }
    public static void Esercizio_18(){
        Random rnd = new Random();
        int random = rnd.Next(1,10);

        Console.WriteLine("Indovina il numero:");
        int inserimento = int.Parse(Console.ReadLine());

        if(random == inserimento)
        Console.WriteLine("Hai indovinato");
        else
        Console.WriteLine($"Non hai indovinato, il numero random era : {random}");
    }
    public static void Esercizio_19(){

        Console.WriteLine("Inserisci i giorni da simulare : \n");
        const double minTemp= 5.4;
        const double maxTemp= 20.2;
        double somma = 0;
        
        int inserimento = int.Parse(Console.ReadLine());  ;
        Random rnd = new Random();

        
      
        double[] temperature = new double[inserimento];
        double max=0;
        double min=30;

        for(int i=0; i< inserimento;i++)
        {
            temperature[i] = rnd.NextDouble() * (maxTemp -minTemp) + minTemp;
        }

        //Stampa tutte le temperature,calcola la somma e 
        foreach (double item in temperature)
        {
            Console.WriteLine(item);
            somma += item;
            if(max <= item)
            max = item;
            if(min >= item)
            min = item;
            
        }

        Console.WriteLine($"La temperatura minima è : {min}\nLa temperatura massima è {max}");
        Console.WriteLine($"La temperatura media è {somma/inserimento}");
        

        
    }
    public static void Esercizio_20()
    {
        try
        {
            Console.Write("Inserisci il primo numero: ");
            int inserimento1 = int.Parse(Console.ReadLine());
            Console.Write("Inserisci il secondo numero: ");
            int inserimento2 = int.Parse(Console.ReadLine());
            Console.WriteLine("La somma dei due numeri è: " + (inserimento1 + inserimento2));
        }
        catch (FormatException e)
        {
            Console.WriteLine("Inserimento non valido!");
        }
        finally
        {
            Console.WriteLine("Programma Terminato.");
        }
    }
    public static void Esercizio_21()
    {
        try
        {
            Console.Write("Inserisci il primo numero: ");
            int inserimento1 = int.Parse(Console.ReadLine());
            Console.Write("Inserisci il secondo numero: ");
            int inserimento2 = int.Parse(Console.ReadLine());

            Console.WriteLine("La divisione è: " + (inserimento1 / inserimento2));
    }
    catch (FormatException e)
        {
            Console.WriteLine("Inserimento non valido!");
        }
    catch (DivideByZeroException e1)
        {
            Console.WriteLine("Divisione per 0 non è possibile!");
        }
    finally
        {
            Console.WriteLine("Programma Terminato.");
        }
    }
    public static void Esercizio_22()
    {
        int[] numeri = new int[5];
        int somma = 0;
        for(int i=0;i<5;i++)
        {
        try
        {
            Console.Write("Inserisci il numero: ");
            numeri[i] = int.Parse(Console.ReadLine());
            somma += numeri[i];
        }
        catch (FormatException e)
        {
            Console.WriteLine("Inserimento non valido!");
        }
        finally
        {
            Console.WriteLine($"La somma è = {somma}");
        }
           
        }
        Console.WriteLine($"La somma è = {somma}");
    }
    
}