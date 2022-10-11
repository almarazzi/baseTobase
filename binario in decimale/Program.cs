using System;
using System.Collections;
using System.Text;
using System.Text.RegularExpressions;


namespace binario_in_decimale
{
    internal class Program
    {
        static char chrHex(int val)
        {
            if (val >= 0 && val <= 9)
                return (char)('0' + val);
            if (val >= 10 && val <= 15)
                return (char)('A' + (val - 10));
            throw new ArgumentException();
        }



        static char aa(int val)
        {

            if (val >= '0' && val <= '9')
                return (char)(val - '0');
            if (val >= 'A' && val <= 'F')
                return (char)(10 + (val - 'A'));
            throw new ArgumentException();
        }
        private static int BinInDec(string scelta)
        {
            int bit;
            int vdec = 0;
            int peso = 1;
            int y = 0;
            string pattern = @"^[01]*$";
            bool ee = Regex.IsMatch(scelta, pattern);


            int max = scelta.Length;
            for (int i = max - 1; i >= 0; --i)
            {





                bit = Convert.ToInt32(scelta[i].ToString());
                vdec += bit * peso;
                peso = peso * 2;
                Console.Write($"{bit}*{2}^{y}");
                if (y < max - 1)
                {
                    Console.Write("+");
                }
                if (y >= max - 1)
                {
                    Console.Write("=");
                }
                y++;


            }

            Console.Write(vdec);
            return vdec;
        }
        private static (byte s, byte r) Aa(byte a, byte b, byte c)
        {

            switch (a, b, c)
            {
                case (0, 0, 0):
                    return (0, 0);
                case (0, 0, 1):
                case (0, 1, 0):
                case (1, 0, 0):
                    return (1, 0);
                case (0, 1, 1):
                case (1, 1, 0):
                case (1, 0, 1):
                    return (0, 1);
                case (1, 1, 1):
                    return (1, 1);


            }
            throw new ArgumentException();
        }


        static void Main(string[] args)


        {
            bool dd = true;
            while (dd)
            {
                Console.WriteLine("x per converti il numero binario in decimale");
                Console.WriteLine("m per converti il numero binario in ottale");
                Console.WriteLine("n per converti il numero binario in esdecimale");
                Console.WriteLine("k per convertire il numero da esadecimale in binario");
                Console.WriteLine("f per convertire il numero da esadecimale in decimale");
                Console.WriteLine("l per convertire il numero da ottale in decimale");
                Console.WriteLine("c per convertire il numero decimale in binario");
                Console.WriteLine("a per convertire il numero da decimale in ottale");
                Console.WriteLine("g per convertire il numero da decimale in esadecimale");
                Console.WriteLine("w per uasre la funzione di calcolatrice");
                Console.WriteLine("r per sommare in binario");
                var scelta2 = Console.ReadLine();
                string pattern1 = @"^([a-zA-Z])$";
                bool scelta1 = Regex.IsMatch(scelta2, pattern1); // mi da falso o vero per il gurppo devo fare match.grups


                if (scelta1 == true)
                {

                }
                else
                {
                    Console.WriteLine("devi inserire una lettera");
                    scelta2 = Console.ReadLine();
                }
                while (scelta2 == "x")
                {
                    Console.WriteLine("dammi il numero in binario");
                    var l = Console.ReadLine();
                    BinInDec(l);

                    if (scelta2 == "x")
                    {
                        break;
                    }
                }

                while (scelta2 == "l")
                {
                    int bit;
                    int vdec = 0;
                    int peso = 1;
                    int y = 0;

                    string patternOtt = @"^([0-7]*)$";
                    Console.WriteLine("dammi il numero ottale");
                    var scelta = Console.ReadLine();
                    bool regexOtt = Regex.IsMatch(scelta, patternOtt);
                    if (regexOtt == false)
                    {
                        break;
                    }
                    int max = scelta.Length;
                    for (int i = max - 1; i >= 0; --i)
                    {
                        bit = Convert.ToInt32(scelta[i].ToString());
                        vdec += bit * peso;
                        peso = peso * 8;
                        Console.Write($"{bit}*{8}^{y}");
                        if (y < max - 1)
                        {
                            Console.Write("+");
                        }
                        if (y >= max - 1)
                        {
                            Console.Write("=");
                        }
                        y++;

                    }


                    Console.WriteLine(vdec);
                    if (scelta2 == "l")
                    {
                        break;
                    }
                }

                while (scelta2 == "f")
                {

                    int bit;
                    int vdec = 0;
                    int peso = 1;
                    string y;
                    int u = 0;
                    Console.WriteLine();
                    Console.WriteLine("dammi il numero eadecimale");
                    string patternEsc = @"^([a-f]*[0-9]*)$";
                    var scelta = Console.ReadLine();
                    bool EscT = Regex.IsMatch(scelta, patternEsc);
                    if (EscT == false)
                    {
                        break;
                    }
                    y = scelta.ToUpper();
                    int max = scelta.Length;

                    for (int i = max - 1; i >= 0; --i)
                    {

                        bit = Convert.ToInt32((int)aa(y[i]));
                        vdec += bit * peso;
                        peso = peso * 16;
                        Console.Write($"{bit}*{16}^{u}");
                        if (u < max - 1)
                        {
                            Console.Write("+");
                        }
                        if (u >= max - 1)
                        {
                            Console.Write("=");
                        }
                        u++;

                    }
                    Console.Write(vdec);
                    if (scelta2 == "f")
                    {
                        break;
                    }

                }

                while (scelta2 == "c")
                {

                    int y;
                    int p = 0;
                    Console.WriteLine();
                    Console.WriteLine("dammi il numero decimale");
                    var scelta = Convert.ToInt32(Console.ReadLine());
                    Stack aa = new Stack();


                    while (scelta != 0)
                    {
                        p++;
                        y = scelta % 2;
                        aa.Push(y);
                        scelta = scelta / 2;
                        Console.WriteLine($"{scelta}|{y}");
                    }
                    int[] gg = new int[p];

                    for (int i = gg.Length - 1; i >= 0; i--)
                    {

                        gg[i] = Convert.ToInt32(aa.Pop());

                    }
                    for (int i = gg.Length - 1; i >= 0; i--)
                    {

                        Console.Write(gg[i]);
                    }
                    if (scelta2 == "c")
                    {
                        break;
                    }
                }

                while (scelta2 == "a")
                {
                    int resto;
                    int pp = 0;
                    Console.WriteLine();
                    Console.WriteLine("dammi il numero decimale");
                    var kk = Convert.ToInt32(Console.ReadLine());
                    Stack s = new Stack();


                    while (kk != 0)
                    {
                        pp++;
                        resto = kk % 8;
                        s.Push(resto);
                        kk = kk / 8;
                        Console.WriteLine($"{kk}|{resto}");
                    }
                    int[] ss = new int[pp];

                    for (int i = ss.Length - 1; i >= 0; i--)
                    {

                        ss[i] = Convert.ToInt32(s.Pop());

                    }
                    for (int i = ss.Length - 1; i >= 0; i--)
                    {

                        Console.Write(ss[i]);
                    }

                    if (scelta2 == "a")
                    {
                        break;
                    }

                }

                while (scelta2 == "g")
                {
                    int resto;
                    int pp = 0;
                    Console.WriteLine();
                    Console.WriteLine("dammi il numero decimale");
                    var kk = Convert.ToInt32(Console.ReadLine());
                    Stack s = new Stack();

                    while (kk != 0)
                    {
                        pp++;
                        resto = kk % 16;
                        s.Push(resto);
                        kk = kk / 16;
                        Console.WriteLine($"{kk}|{resto}");
                    }
                    int[] ss = new int[pp];

                    for (int i = ss.Length - 1; i >= 0; i--)
                    {

                        ss[i] = Convert.ToInt32(s.Pop());

                    }
                    for (int i = ss.Length - 1; i >= 0; i--)
                    {

                        Console.Write(chrHex(ss[i]).ToString());
                    }

                    if (scelta2 == "g")
                    {
                        break;
                    }
                }
                while (scelta2 == "m")
                {
                    int bit;
                    int vdec = 0;
                    int peso = 1;
                    int resto;
                    int pp = 0;
                    int o = 0;
                    int uu = 0;
                    string patternOTT = @"^([0-1]*)$";
                    Console.WriteLine("dammi il numero binario");
                    var scelta = Console.ReadLine();
                    bool OTT = Regex.IsMatch(scelta, patternOTT);
                    int max = scelta.Length;
                    if (OTT == false)
                    {
                        break;
                    }
                    for (int i = max - 1; i >= 0; --i)
                    {
                        bit = Convert.ToInt32(scelta[i].ToString());
                        vdec += bit * peso;
                        peso = peso * 2;
                        Console.Write($"{bit}*{2}^{o}");
                        if (o < max - 1)
                        {
                            Console.Write("+");
                        }
                        if (o >= max - 1)
                        {
                            Console.Write("=");
                        }
                        o++;
                    }
                    Console.Write(vdec);
                    Console.WriteLine(" ");
                    Stack s = new Stack();
                    uu = vdec;

                    while (vdec != 0)
                    {
                        pp++;
                        resto = vdec % 8;
                        s.Push(resto);
                        vdec = vdec / 8;
                    }
                    int[] ss = new int[pp];

                    for (int i = ss.Length - 1; i >= 0; i--)
                    {

                        ss[i] = Convert.ToInt32(s.Pop());

                    }
                    Console.WriteLine($"{uu}|{8}");
                    for (int i = ss.Length - 1; i >= 0; --i)
                    {
                        uu = uu / 8;
                        Console.WriteLine($" {uu}|{ss[i]}");
                    }
                    for (int i = ss.Length - 1; i >= 0; i--)
                    {
                        Console.Write(ss[i]);
                    }

                    if (scelta2 == "m")
                    {
                        break;
                    }
                }
                while (scelta2 == "n")
                {
                    int bit;
                    int vdec = 0;
                    int peso = 1;
                    int resto;
                    int pp = 0;
                    int o = 0;
                    int uu = 0;

                    Console.WriteLine("dammi il numero binario");
                    var scelta = Console.ReadLine();
                    int max = scelta.Length;

                    for (int i = max - 1; i >= 0; --i)
                    {
                        bit = Convert.ToInt32(scelta[i].ToString());
                        vdec += bit * peso;
                        peso = peso * 2;
                        Console.Write($"{bit}*{2}^{o}");
                        if (o < max - 1)
                        {
                            Console.Write("+");
                        }
                        if (o >= max - 1)
                        {
                            Console.Write("=");
                        }
                        o++;
                    }
                    Console.Write(vdec);
                    Console.WriteLine(" ");
                    Stack s = new Stack();
                    uu = vdec;

                    while (vdec != 0)
                    {
                        pp++;
                        resto = vdec % 16;
                        s.Push(resto);
                        vdec = vdec / 16;
                    }
                    int[] ss = new int[pp];
                    for (int i = ss.Length - 1; i >= 0; i--)
                    {

                        ss[i] = Convert.ToInt32(s.Pop());

                    }
                    Console.WriteLine($"{uu}|{16}");
                    for (int i = ss.Length - 1; i >= 0; --i)
                    {
                        uu = uu / 16;
                        Console.WriteLine($" {uu}|{ss[i]}");
                    }
                    for (int i = ss.Length - 1; i >= 0; i--)
                    {
                        Console.Write(chrHex(ss[i]).ToString());
                    }

                    if (scelta2 == "n")
                    {
                        break;
                    }
                }

                while (scelta2 == "k")
                {
                    int y = 0;
                    int p = 0;
                    int bit = 0;
                    int o = 0;
                    int vdec = 0;
                    int peso = 1;
                    string a;
                    int uu = 0;
                    int u = 0;
                    Console.WriteLine();
                    Console.WriteLine("dammi il numero esdecimale");
                    var scelta = Console.ReadLine();
                    Stack cc = new Stack();
                    int max = scelta.Length;
                    int[] bb = new int[max];
                    a = scelta.ToUpper();
                    for (int i = 0; i <= max - 1; ++i)
                    {
                        o = (int)aa(a[i]);
                        bb[i] = o;
                    }

                    for (int i = max - 1; i >= 0; --i)
                    {
                        bit = bb[i];
                        vdec += bit * peso;
                        peso = peso * 16;
                        Console.Write($"{bit}*{16}^{u}");
                        if (u < max - 1)
                        {
                            Console.Write("+");
                        }
                        if (u >= max - 1)
                        {
                            Console.Write("=");
                        }
                        u++;
                    }
                    Console.Write(vdec);
                    Console.WriteLine(" ");
                    uu = vdec;
                    while (vdec != 0)
                    {
                        p++;
                        max--;
                        y = vdec % 2;
                        cc.Push(y);
                        vdec = vdec / 2;
                    }
                    int[] gg = new int[p];
                    for (int i = gg.Length - 1; i >= 0; i--)
                    {

                        gg[i] = Convert.ToInt32(cc.Pop());

                    }
                    Console.WriteLine($"{uu}|{16}");
                    for (int i = gg.Length - 1; i >= 0; --i)
                    {
                        uu = uu / 16;
                        Console.WriteLine($" {uu}|{gg[i]}");
                    }
                    for (int i = gg.Length - 1; i >= 0; i--)
                    {

                        Console.Write(gg[i]);
                    }
                    if (scelta2 == "k")
                    {
                        break;
                    }


                }
                while (scelta2 == "w")
                {

                    long somma = 0;
                    long differenza = 0;
                    long moltipicazione = 0;
                    long divizione = 0;
                    string pp = @"^\s*([0-9]+)\s*([\+\-\*\/])\s*([0-9]+)\s*$";
                    Console.Write("metti l'operazione->");
                    var i = Console.GetCursorPosition();
                    var s = Convert.ToString(Console.ReadLine());
                    var oo = Regex.Match(s, pp).Groups;
                    long adento = Convert.ToInt64(oo[1].Value);
                    long adento1 = Convert.ToInt64(oo[3].Value);
                    Console.WriteLine(i);

                    if (Convert.ToString(oo[2]) == "+")
                    {

                        somma = adento + adento1;
                        Console.SetCursorPosition((oo[1].Length + oo[3].Length + 1 + i.Left), i.Top);
                        Console.Write("=" + somma);
                    }
                    if (Convert.ToString(oo[2]) == "-")
                    {

                        differenza = adento - adento1;
                        Console.SetCursorPosition((oo[1].Length + oo[3].Length + 1 + i.Left), i.Top);
                        Console.WriteLine("=" + differenza);
                    }
                    if (Convert.ToString(oo[2]) == "*")
                    {

                        moltipicazione = adento * adento1;
                        Console.SetCursorPosition((oo[1].Length + oo[3].Length + 1 + i.Left), i.Top);
                        Console.WriteLine("=" + moltipicazione);
                    }
                    if (Convert.ToString(oo[2]) == "/")
                    {

                        divizione = adento / adento1;
                        Console.SetCursorPosition((oo[1].Length + oo[3].Length + 1 + i.Left), i.Top);
                        Console.WriteLine("=" + divizione);
                    }

                    /*
                     int x=0;
                     int a = 1;
                     int b = 2;
                     Console.WriteLine(a);
                     Console.WriteLine(b);
                     x = a;
                     a = b;
                     b = x;
                     Console.WriteLine(a);
                     Console.WriteLine(b);
                    */
                    if (scelta2 == "w")
                    {
                        break;
                    }


                }

                while (scelta2 == "r")
                {

                    Console.WriteLine("dammi il numero binario");
                    var scelta = Console.ReadLine();
                    Console.WriteLine("dammi il 2 numero binario");
                    var scelta1_1 = Console.ReadLine();


                    Console.WriteLine(" ");
                    Console.WriteLine($"{scelta} +");
                    Console.WriteLine($"{scelta1_1} =");

                    int[] qq = new int[32];
                    int[] qq1 = new int[32];

                    byte r1 = 0;
                    int y = 0;
                    for (int i = scelta.Length - 1; i >= 0; i--)
                    {

                        qq[y] = Convert.ToInt32(scelta[i].ToString());
                        // qq[i] = Convert.ToInt16(scelta[i].ToString());
                        y++;

                    }
                    int t = 0;
                    for (int i = scelta1_1.Length - 1; i >= 0; i--)
                    {

                        qq1[t] = Convert.ToInt32(scelta1_1[i].ToString());
                        //qq1[i] = Convert.ToInt16(scelta1_1[i].ToString());
                        t++;
                    }
                    var string1 = new StringBuilder();
                    Stack ss = new Stack();
                    for (int i = 0; i <= Math.Max(scelta.Length, scelta1_1.Length); i++)
                    {
                        var (s, r) = Aa(r1, (byte)qq[i], (byte)qq1[i]);
                        r1 = r;
                        ss.Push(s);
                       
                       
                      

                    }
                    for (int i = ss.Count-1; i >= 0; i--)
                    {
                      var ff =  ss.Pop();
                        string1.Append(ff);
                        Console.Write("-");
                        
                    }
                    Console.WriteLine("");
                    Console.WriteLine($"{string1}");

                    if (scelta2 == "r")
                    {
                        break;
                    }



                }
                while (scelta2 == "o")
                {
                    int bit;
                    int vdec = 0;
                    int peso = 1;
                    int y = 0;



                    Console.WriteLine("dammi il numero ottale");
                    var scelta = Console.ReadLine();
                    int max = scelta.Length;
                    for (int i = max - 1; i >= 0; --i)
                    {
                        bit = Convert.ToInt32(scelta[i].ToString());
                        vdec += bit * peso;
                        peso = peso * 8;
                        Console.Write($"{bit}*{8}^{y}");
                        if (y < max - 1)
                        {
                            Console.Write("+");
                        }
                        if (y >= max - 1)
                        {
                            Console.Write("=");
                        }
                        y++;

                    }
                    Console.WriteLine(vdec);

                    int u;
                    int k = 0;


                    Stack aa = new Stack();
                    while (vdec != 0)
                    {
                        k++;
                        u = vdec % 2;
                        aa.Push(u);
                        vdec = vdec / 2;
                        //Console.WriteLine($"{scelta}|{y}");
                    }
                    int[] yy = new int[k];

                    for (int i = yy.Length - 1; i >= 0; i--)
                    {

                        yy[i] = Convert.ToInt32(aa.Pop());

                    }
                    for (int i = yy.Length - 1; i >= 0; i--)
                    {

                        Console.Write(yy[i]);
                    }

                    if (scelta2 == "o")
                    {
                        break;
                    }
                }

                Console.WriteLine();
                Console.WriteLine("per continuare permi s se non prei n");
                var sceltax = Console.ReadLine();
                if (sceltax == "s")
                {
                    dd = true;
                    Console.Clear();
                }
                else
                {
                    dd = false;
                }

            }


        }




    }
}
