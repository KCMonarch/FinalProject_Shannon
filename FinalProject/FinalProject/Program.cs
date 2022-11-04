bool f = true;
string line1 = @"                                      ";
string line2 = @" /                                    \";
string line3 = @"/______________________________________\";
string line4 = @"\                                      /";
string line5 = @" \                                    /";
string line6 = @"                  /\                  ";
string line7  = @"                 /__\";
string line8  = @"                /____\";
string line9  = @"               /______\";
string line10 = @"              /________\           ";
string line11 = @"             /__________\           ";
string line12 = @"            /____________\";
string line13 = @"           /______________\";
string line14 = @"          /________________\ ";
string line15 = @"          \________________/";
string line16 = @"           \______________/";
string line17 = @"            \____________/";
string line18 = @"             \__________/";
string line19 = @"              \________/           ";
string line20 = @"              /________\           ";
string line21 = @"             /__________\           ";
string line22 = @"            /____________\";
string line23 = @"           /______________\";
string line24 = @"          /________________\ ";
string line25 = @"          \________________/";
string line26 = @"           \______________/";
string line27 = @"            \____________/";
string line28 = @"             \__________/";
string line29 = @"              \________/";
string line30 = @"               \______/";
string line31 = @"                \____/";
string line32 = @"                 \__/";
string line33 = @"                  \/";
string line34 = @"   ";
string line35 = @"  /                                  \";
string line36 = @" /                                    \";
string line37 = @"/______________________________________\";
string line38 = @"\                                      /";
string line39 = @" \                                    /";
string line40 = @"  \                                  /";
string input;
int i = 0;
int n = 0;
int d = 0;
int l = 10;
int w = 0;
while (f == true)
{
    Console.WriteLine("Write 'left' to make image to move left or write 'right' to make image move right or write 'reset' to reset the program or write 'up' to move the image up or write 'down' to move the image down or write\n anything else to end the program");
    Console.WriteLine("Warning it is possible to delete image by using 'left' without using 'right' first");
    Console.WriteLine("Zoom out a lot to see image");
    input = Console.ReadLine();
    input = input.ToLower();
    if(input == "right") { i = 1; } else if (input == "left") { i = 2; } else if (input == "reset") { i = 3; } else if (input == "down"){ i = 4; }else if(input == "up") { i = 5; } else { i = 6; }
    switch (i) {
        case 1:
            if (w >= 150) { Console.Clear(); Console.WriteLine("This will mess up image"); }
            else
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Clear();
                    Console.WriteLine(line1);  line1 = line1.Insert(0, " ");
                    Console.WriteLine(line2); line2 = line2.Insert(0, " ");
                    Console.WriteLine(line3); line3 = line3.Insert(0, " ");
                    Console.WriteLine(line4); line4 = line4.Insert(0, " ");
                    Console.WriteLine(line5); line5 = line5.Insert(0, " ");
                    Console.WriteLine(line6); line6 = line6.Insert(0, " ");
                    Console.WriteLine(line7); line7 = line7.Insert(0, " ");
                    Console.WriteLine(line8); line8 = line8.Insert(0, " ");
                    Console.WriteLine(line9); line9 = line9.Insert(0, " ");
                    Console.WriteLine(line10); line10 = line10.Insert(0, " ");
                    Console.WriteLine(line11); line11 = line11.Insert(0, " ");
                    Console.WriteLine(line12); line12 = line12.Insert(0, " ");
                    Console.WriteLine(line13); line13 = line13.Insert(0, " ");
                    Console.WriteLine(line14); line14 = line14.Insert(0, " ");
                    Console.WriteLine(line15); line15 = line15.Insert(0, " ");
                    Console.WriteLine(line16); line16 = line16.Insert(0, " ");
                    Console.WriteLine(line17); line17 = line17.Insert(0, " ");
                    Console.WriteLine(line18); line18 = line18.Insert(0, " ");
                    Console.WriteLine(line19); line19 = line19.Insert(0, " ");
                    Console.WriteLine(line20); line20 = line20.Insert(0, " ");
                    Console.WriteLine(line21); line21 = line21.Insert(0, " ");
                    Console.WriteLine(line22); line22 = line22.Insert(0, " ");
                    Console.WriteLine(line23); line23 = line23.Insert(0, " ");
                    Console.WriteLine(line24); line24 = line24.Insert(0, " ");
                    Console.WriteLine(line25); line25 = line25.Insert(0, " ");
                    Console.WriteLine(line26); line26 = line26.Insert(0, " ");
                    Console.WriteLine(line27); line27 = line27.Insert(0, " ");
                    Console.WriteLine(line28); line28 = line28.Insert(0, " ");
                    Console.WriteLine(line29); line29 = line29.Insert(0, " ");
                    Console.WriteLine(line30); line30 = line30.Insert(0, " ");
                    Console.WriteLine(line31); line31 = line31.Insert(0, " ");
                    Console.WriteLine(line32); line32 = line32.Insert(0, " ");
                    Console.WriteLine(line33); line33 = line33.Insert(0, " ");
                    Console.WriteLine(line34); line34 = line34.Insert(0, " ");
                    Console.WriteLine(line35); line35 = line35.Insert(0, " ");
                    Console.WriteLine(line36); line36 = line36.Insert(0, " ");
                    Console.WriteLine(line37); line37 = line37.Insert(0, " ");
                    Console.WriteLine(line38); line38 = line38.Insert(0, " ");
                    Console.WriteLine(line39); line39 = line39.Insert(0, " ");
                    Console.WriteLine(line40); line40 = line40.Insert(0, " ");
                    Thread.Sleep(4);
                    d++;
                    w++;
                }
            }
            break;
        case 2:
            for (int j = 0; j < 10; j++)
            {
                if (d <= 1) { Console.Clear(); Console.WriteLine("Cannot do this because this will delete image"); j = 23; }
                else
                {
                    Console.Clear();
                    Console.WriteLine(line1); line1 = line1.Remove(0, 1);
                    Console.WriteLine(line2); line2 = line2.Remove(0, 1);
                    Console.WriteLine(line3); line3 = line3.Remove(0, 1);
                    Console.WriteLine(line4); line4 = line4.Remove(0, 1);
                    Console.WriteLine(line5); line5 = line5.Remove(0, 1);
                    Console.WriteLine(line6); line6 = line6.Remove(0, 1);
                    Console.WriteLine(line7); line7 = line7.Remove(0, 1);
                    Console.WriteLine(line8); line8 = line8.Remove(0, 1);
                    Console.WriteLine(line9); line9 = line9.Remove(0, 1);
                    Console.WriteLine(line10); line10 = line10.Remove(0, 1);
                    Console.WriteLine(line11); line11 = line11.Remove(0, 1);
                    Console.WriteLine(line12); line12 = line12.Remove(0, 1);
                    Console.WriteLine(line13); line13 = line13.Remove(0, 1);
                    Console.WriteLine(line14); line14 = line14.Remove(0, 1);
                    Console.WriteLine(line15); line15 = line15.Remove(0, 1);
                    Console.WriteLine(line16); line16 = line16.Remove(0, 1);
                    Console.WriteLine(line17); line17 = line17.Remove(0, 1);
                    Console.WriteLine(line18); line18 = line18.Remove(0, 1);
                    Console.WriteLine(line19); line19 = line19.Remove(0, 1);
                    Console.WriteLine(line20); line20 = line20.Remove(0, 1);
                    Console.WriteLine(line21); line21 = line21.Remove(0, 1);
                    Console.WriteLine(line22); line22 = line22.Remove(0, 1);
                    Console.WriteLine(line23); line23 = line23.Remove(0, 1);
                    Console.WriteLine(line24); line24 = line24.Remove(0, 1);
                    Console.WriteLine(line25); line25 = line25.Remove(0, 1);
                    Console.WriteLine(line26); line26 = line26.Remove(0, 1);
                    Console.WriteLine(line27); line27 = line27.Remove(0, 1);
                    Console.WriteLine(line28); line28 = line28.Remove(0, 1);
                    Console.WriteLine(line29); line29 = line29.Remove(0, 1);
                    Console.WriteLine(line30); line30 = line30.Remove(0, 1);
                    Console.WriteLine(line31); line31 = line31.Remove(0, 1);
                    Console.WriteLine(line32); line32 = line32.Remove(0, 1);
                    Console.WriteLine(line33); line33 = line33.Remove(0, 1);
                    Console.WriteLine(line34); line34 = line34.Remove(0, 1);
                    Console.WriteLine(line35); line35 = line35.Remove(0, 1);
                    Console.WriteLine(line36); line36 = line36.Remove(0, 1);
                    Console.WriteLine(line37); line37 = line37.Remove(0, 1);
                    Console.WriteLine(line38); line38 = line38.Remove(0, 1);
                    Console.WriteLine(line39); line39 = line39.Remove(0, 1);
                    Console.WriteLine(line40); line40 = line40.Remove(0, 1);
                    Thread.Sleep(4);
                    d--;
                    w--;
                }
            }
            break;
        case 3:
             line1 = @"                                      ";
             line2 = @" /                                    \";
             line3 = @"/______________________________________\";
             line4 = @"\                                      /";
             line5 = @" \                                    /";
             line6 = @"                  /\                  ";
             line7 = @"                 /__\";
             line8 = @"                /____\";
             line9 = @"               /______\";
             line10 = @"              /________\           ";
             line11 = @"             /__________\           ";
             line12 = @"            /____________\";
             line13 = @"           /______________\";
             line14 = @"          /________________\ ";
             line15 = @"          \________________/";
            line16 = @"           \______________/";
            line17 = @"            \____________/";
            line18 = @"             \__________/";
            line19 = @"              \________/           ";
             line20 = @"              /________\           ";
             line21 = @"             /__________\           ";
             line22 = @"            /____________\";
             line23 = @"           /______________\";
             line24 = @"          /________________\ ";
             line25 = @"          \________________/";
             line26 = @"           \______________/";
             line27 = @"            \____________/";
             line28 = @"             \__________/";
             line29 = @"              \________/";
             line30 = @"               \______/";
             line31 = @"                \____/";
             line32 = @"                 \__/";
            line33 = @"                  \/";
             line34 = @"   ";
             line35 = @"  /                                  \";
             line36 = @" /                                    \";
             line37 = @"/______________________________________\";
             line38 = @"\                                      /";
             line39 = @" \                                    /";
             line40 = @"  \                                  /";
            Console.Clear();
            Console.WriteLine(line1); 
            Console.WriteLine(line2);
            Console.WriteLine(line3);
                Console.WriteLine(line4);
            Console.WriteLine(line5);
            Console.WriteLine(line6);
            Console.WriteLine(line7);
            Console.WriteLine(line8);
            Console.WriteLine(line9);
            Console.WriteLine(line10);
            Console.WriteLine(line11);
            Console.WriteLine(line12);
            Console.WriteLine(line13);
            Console.WriteLine(line14);
            Console.WriteLine(line15);
            Console.WriteLine(line16);
            Console.WriteLine(line17);
                Console.WriteLine(line18);
            Console.WriteLine(line19);
            Console.WriteLine(line20);
            Console.WriteLine(line21);
            Console.WriteLine(line22);
            Console.WriteLine(line23);
            Console.WriteLine(line24);
            Console.WriteLine(line25);
            Console.WriteLine(line26);
            Console.WriteLine(line27);
            Console.WriteLine(line28);
            Console.WriteLine(line29);
            Console.WriteLine(line30);
            Console.WriteLine(line31);
            Console.WriteLine(line32);
            Console.WriteLine(line33);
            Console.WriteLine(line34);
            Console.WriteLine(line35);
            Console.WriteLine(line36);
                
            Console.WriteLine(line37);
            Console.WriteLine(line38);
            Console.WriteLine(line39);
            Console.WriteLine(line40);
            d = 0;
            w= 0;
            n= 0;
            break;
        case 4:
       
       
            for (int k = 0; k < l; k++) { line1 = line1.Insert(0, "  \n"); n++; Console.Clear();
                Console.WriteLine(line1);
                Console.WriteLine(line2);
                Console.WriteLine(line3);
                Console.WriteLine(line4);
                Console.WriteLine(line5);
                Console.WriteLine(line6);
                Console.WriteLine(line7);
                Console.WriteLine(line8);
                Console.WriteLine(line9);
                Console.WriteLine(line10);
                Console.WriteLine(line11);
                Console.WriteLine(line12);
                Console.WriteLine(line13);
                Console.WriteLine(line14);
                Console.WriteLine(line15);
                Console.WriteLine(line16);
                Console.WriteLine(line17);
                Console.WriteLine(line18);
                Console.WriteLine(line19);
                Console.WriteLine(line20);
                Console.WriteLine(line21);
                Console.WriteLine(line22);
                Console.WriteLine(line23);
                Console.WriteLine(line24);
                Console.WriteLine(line25);
                Console.WriteLine(line26);
                Console.WriteLine(line27);
                Console.WriteLine(line28);
                Console.WriteLine(line29);
                Console.WriteLine(line30);
                Console.WriteLine(line31);
                Console.WriteLine(line32);
                Console.WriteLine(line33);
                Console.WriteLine(line34);
                Console.WriteLine(line35);
                Console.WriteLine(line36);

                Console.WriteLine(line37);
                Console.WriteLine(line38);
                Console.WriteLine(line39);
                Console.WriteLine(line40);
                Thread.Sleep(7);
            }
               
           

            
            break;
        case 5:
            line1 = @"                                      ";
            
            for (int j = 0; j < 10; j++)
            {
                for (int k = 0; k < w; k++) { line1 = line1.Insert(0, " "); }
                line1 = @"                                      ";
                Console.Clear();
                for (int k = 0; k < n - 10; k++)
                {
                    Console.Clear();
                    line1 = line1.Insert(0, "  \n"); Console.WriteLine(line1);
                    Console.WriteLine(line2);
                    Console.WriteLine(line3);
                    Console.WriteLine(line4);
                    Console.WriteLine(line5);
                    Console.WriteLine(line6);
                    Console.WriteLine(line7);
                    Console.WriteLine(line8);
                    Console.WriteLine(line9);
                    Console.WriteLine(line10);
                    Console.WriteLine(line11);
                    Console.WriteLine(line12);
                    Console.WriteLine(line13);
                    Console.WriteLine(line14);
                    Console.WriteLine(line15);
                    Console.WriteLine(line16);
                    Console.WriteLine(line17);
                    Console.WriteLine(line18);
                    Console.WriteLine(line19);
                    Console.WriteLine(line20);
                    Console.WriteLine(line21);
                    Console.WriteLine(line22);
                    Console.WriteLine(line23);
                    Console.WriteLine(line24);
                    Console.WriteLine(line25);
                    Console.WriteLine(line26);
                    Console.WriteLine(line27);
                    Console.WriteLine(line28);
                    Console.WriteLine(line29);
                    Console.WriteLine(line30);
                    Console.WriteLine(line31);
                    Console.WriteLine(line32);
                    Console.WriteLine(line33);
                    Console.WriteLine(line34);
                    Console.WriteLine(line35);
                    Console.WriteLine(line36);

                    Console.WriteLine(line37);
                    Console.WriteLine(line38);
                    Console.WriteLine(line39);
                    Console.WriteLine(line40);
                    Thread.Sleep(7);
                }
                Thread.Sleep(7);
                n --;
            }
               
            
            break;
        default:
            f = false;
            Console.WriteLine("Program is now Finished");
            break;
    }
}
