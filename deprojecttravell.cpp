#include <conio.h>
#include <stdio.h>
#include <iostream>
#include <string>
#include <windows>

//    propertise     //
//    width  :153    //
//    height :80     //

//=============================== K E L O M P O K ============================//
//                                                                            //
//                               Fenita Oktaviani                             //
//                                  Hadiyanto                                 //
//                                Ihsan Nasihin                               //
//                                                                            //
//============================================================================//

void infojurusan();
void inputpel();
void desainpinggir();
void bck();
void batasdesain();
void menuawal();
void lihat();
void edit();
void hapus();
void tambah();
void login();


string jur;
struct pesaniden{
	int id;
	string nama;
	string no_hape;
	string tempat_tinggal;
	string alamat_jemput;
	int jumlah_orang;
	int jumlah_bayar;
}identitas[20];
struct pesanjur{
	string jurusan;
	string tanggal;
	string jam;
}jurus[20];
struct adminn{
	string user;
   string pass;
}adm[5];

int kode,pelanggan=0;
string tggl;
char pilihan[100];
int harga[5]={250000,100000,50000,350000,80000};
string kota[5]={"Purwokerto","Jakarta","Garut","Semarang","Ciamis"};
int stok[5]={14,14,14,14,14};
int dmin=1;

////////////////////////////////////////////////////////////////////////////////
//                                                                            //
//										 CLASS TRAVEL                                   //
//                                                                            //
////////////////////////////////////////////////////////////////////////////////

class travel{
	protected :
   	int harga;
      int uang;
   public :
   	void setharga(int a){
      	harga=a;
      }void setuang(int b){
      	uang=b;
      }
};
////////////////////////////////////////////////////////////////////////////////
//                                                                            //
//                              CLASS PEMBAYARAN                              //
//                                                                            //
////////////////////////////////////////////////////////////////////////////////

class pembayaran:public travel{
	public:
   	int kembalian(){
      	return uang-harga;
      }
};
////////////////////////////////////////////////////////////////////////////////
//                                                                            //
//                           VOID MENU AWAL                                   //
//                                                                            //
////////////////////////////////////////////////////////////////////////////////
void menuawal(){
   desainpinggir();
	bck();
	batasdesain();

   textbackground(3);
   textcolor(4);
   gotoxy(70,6);cprintf("KEBERANGKATAN UNTUK TANGGAL");
   gotoxy(73,8);cprintf("     %s", tggl);
   gotoxy(75,20);cprintf("Masukkan Pilihan : ");
   cin>>pilihan;
   if (strcmp(pilihan,"1")==0){
   	infojurusan();
   }else if(strcmp(pilihan,"2")==0){
   	textbackground(3);
   	textcolor(4);
   	gotoxy(6,23);cprintf("2. Tambah Admin");
      tambah();
   }else if(strcmp(pilihan,"3")==0){
   	lihat();
   }else if(strcmp(pilihan,"4")==0){
   	textbackground(3);
   	textcolor(4);
   	gotoxy(6,37);cprintf("4. Keluar");
   	gotoxy(72,25);cout<<"---- Terimakasih Sudah Berkunjung -----";Sleep(1000);
      exit(0);
   }else{
   	textbackground(3);
   	textcolor(4);
   	gotoxy(80,23);cprintf("Invalid input");Sleep(1000);
      gotoxy(80,23);cprintf("                   ");
      gotoxy(75,20);cprintf("                       ");
      menuawal();
   }
}
////////////////////////////////////////////////////////////////////////////////
//                                                                            //
//                            VOID DESIGN PINGGIR                             //
//                                                                            //
////////////////////////////////////////////////////////////////////////////////
void desainpinggir(){
	int b=1;
	for(int a=1;a<151;a++){
		gotoxy(a+1,2);printf("%c",219);Sleep(0);
      gotoxy(a+1,41);printf("%c",219);Sleep(0);
     // if(a==151){
     // 	gotoxy(2,b+3);printf("%c",219);Sleep(0);
      //}
      if(a%3==0 && a<122){
      	b++;
      	gotoxy(2,b);printf("%c",219);Sleep(0);
         gotoxy(152,b);printf("%c",219);Sleep(0);
      }
   }
}
////////////////////////////////////////////////////////////////////////////////
//                                                                            //
//                          VOID BCK                                          //
//                                                                            //
////////////////////////////////////////////////////////////////////////////////
void bck(){
	for(int a=1;a<150;a++){
   	for(int b=1;b<39;b++){
      	textcolor(3);
			gotoxy(a+2,b+2);cprintf("%c",219);Sleep(1/3);
      }
   }
}
////////////////////////////////////////////////////////////////////////////////
//                                                                            //
//                         VOID BATAS DESIGN                                  //
//                                                                            //
////////////////////////////////////////////////////////////////////////////////
void batasdesain(){
	//int b=1;
	for(int a=1;a<120;a++){

         if(a<39){
   			gotoxy(32,a+2);printf("%c",219);Sleep(1);
        		 if(a<32){
   				gotoxy(a+1,13);printf("%c",219);Sleep(1);     //kanan atas
      			gotoxy(a+1,20);printf("%c",219);Sleep(1);
      			gotoxy(a+1,27);printf("%c",219);Sleep(1);
      			gotoxy(a+1,34);printf("%c",219);Sleep(1);
      		}
         }
         gotoxy(a+32,10);printf("%c",219);Sleep(1);
   }
  	textbackground(3);
  	textcolor(15);
   gotoxy(5, 6);cprintf("MM MM  EEEE  N   N  U   U");Sleep(1);
   gotoxy(5, 7);cprintf("M M M  E     NN  N  U   U");Sleep(1);
	gotoxy(5, 8);cprintf("M   M  EEE   N N N  U   U");Sleep(1);
	gotoxy(5, 9);cprintf("M   M  E     N  NN  U   U");Sleep(1);
   gotoxy(5,10);cprintf("M   M  EEEE  N   N   UUU");Sleep(1);
   gotoxy(6,16);cprintf("1. Pesan Travel");
   gotoxy(6,23);cprintf("2. Tambah Admin");
   gotoxy(6,30);cprintf("3. Lihat Jadwal");
   gotoxy(6,37);cprintf("4. Keluar");
}
////////////////////////////////////////////////////////////////////////////////
//                                                                            //
//                          VOID LOGO                                         //
//                                                                            //
////////////////////////////////////////////////////////////////////////////////
void logo(){
   bck();
   desainpinggir();
   for(int a=15;a<17;a++){
		textbackground(3);
   	textcolor(a);
   	gotoxy(35, 9);cprintf("TTTTTTTTTTT  RRRRRRR        AAAAAA    NNNN     NN     SSASSS     ____________");Sleep(a);
   	gotoxy(35,10);cprintf("TTTTTTTTTTT  RRRRRRRRR     AAAAAAAA   NNNNN    NN   SSSSSSS  _____");Sleep(a);
		gotoxy(35,11);cprintf("    TTT      RRR    RR    AAA     AA  NNN NN   NN   SSS        _________");Sleep(a);
		gotoxy(35,12);cprintf("    TTT      RRR    RR    AAA     AA  NNN  NN  NN     SS    ___________________________");Sleep(a);
   	gotoxy(35,13);cprintf("    TTT      RRRR RR      AAAAAAAAAA  NNN   NN NN       SSS  _________________");Sleep(a);
   	gotoxy(35,14);cprintf("    TTT      RRR  RR      AAA     AA  NNN    NNNN         SS        ________________");Sleep(a);
   	gotoxy(35,15);cprintf("    TTT      RRR   RR     AAA     AA  NNN      NN        SS  _________");Sleep(a);
		gotoxy(35,16);cprintf("    TTT      RRR    RR    AAA     AA  NNN      NN   SSSSSS     ____________");Sleep(a);
   }
   for(int a=15;a<17;a++){
   	textbackground(3);
   	textcolor(a);
		gotoxy(35,18);cprintf("                ____________   TTTTTTT  RRR    AAA   V   V   EEEE  L");Sleep(50);
   	gotoxy(35,19);cprintf("                          _____   T     R  R  A   A  V   V   E     L   ");Sleep(50);
   	gotoxy(35,20);cprintf("                    _________     T     RRR   AAAAA  V   V   EEE   L  ");Sleep(50);
		gotoxy(35,21);cprintf("    ___________________________   T     R  R  A   A  V   V   E     L    ");Sleep(50);
   	gotoxy(35,22);cprintf("             _________________    T     R  R  A   A    V     EEEE  LLLLL");Sleep(50);
  }
  for(int a=1;a<=100;a++){
  		gotoxy(25+a,29);cprintf("%c",219);Sleep(20);
      gotoxy(25+a,30);cprintf("%c",219);Sleep(20);
      gotoxy(70,34);cprintf("%d %",a);
  }
}
////////////////////////////////////////////////////////////////////////////////
//                                                                            //
//                            VOID LIHAT                                      //
//                                                                            //
////////////////////////////////////////////////////////////////////////////////
void lihat(){
   bck();
   textbackground(3);
   	textcolor(4);
   textcolor(14);
   gotoxy(37,4);cprintf("  LL      II  HH  HH    AA    TTTTTT     DDDDD     AA    TTTTTT    AA    ");Sleep(1);
   gotoxy(37,5);cprintf("  LL      II  HH  HH  AA  AA    TT       DD  DD  AA  AA    TT    AA  AA  ");Sleep(1);
	gotoxy(37,6);cprintf("  LL      II  HHHHHH  AAAAAA    TT       DD  DD  AAAAAA    TT    AAAAAA  ");Sleep(1);
	gotoxy(37,7);cprintf("  LL      II  HH  HH  AA  AA    TT       DD  DD  AA  AA    TT    AA  AA  ");Sleep(1);
   gotoxy(37,8);cprintf("  LLLLLL  II  HH  HH  AA  AA    TT       DDDDD   AA  AA    TT    AA  AA  ");Sleep(1);
   for(int a=1;a<=150;a++){
   	gotoxy(2+a,10);printf("%c",219);
   }
   for(int a=0;a<145;a++){
   	gotoxy(5+a,12);printf("%c",219);
   	gotoxy(5+a,16);printf("%c",219);
   	gotoxy(5+a,18+pelanggan*2);printf("%c",219);
   }
   for(int b=0;b<6+pelanggan*2;b++){
      gotoxy(5,12+b);printf("%c",219);
      gotoxy(15,12+b);printf("%c",219);
      gotoxy(30,12+b);printf("%c",219);
      gotoxy(45,12+b);printf("%c",219);
      gotoxy(60,12+b);printf("%c",219);
      gotoxy(75,12+b);printf("%c",219);
      gotoxy(90,12+b);printf("%c",219);
      gotoxy(105,12+b);printf("%c",219);
      gotoxy(120,12+b);printf("%c",219);
      gotoxy(135,12+b);printf("%c",219);
      gotoxy(149,12+b);printf("%c",219);
   }gotoxy(9,14);printf("id");
   gotoxy(17,14);printf("Nama lengkap");
   gotoxy(34,14);printf("no hape");
   gotoxy(46,14);printf("tempat tinggal");
   gotoxy(62,14);printf("alamat jemput");
   gotoxy(77,14);printf("Jumlah orang");
   gotoxy(94,14);printf("Jurusan");
   gotoxy(109,14);printf("tanggal");
   gotoxy(125,14);printf("waktu");
   gotoxy(137,14);printf("Total bayar");
   int z=2;
   for(int a=0;a<pelanggan;a++){
   	if(identitas[a].id!=0){
       	gotoxy(7,16+z);printf("%d",identitas[a].id);
   		gotoxy(17,16+z);printf("%s",identitas[a].nama);
   		gotoxy(32,16+z);printf("%s",identitas[a].no_hape);
   		gotoxy(47,16+z);printf("%s",identitas[a].tempat_tinggal);
	   	gotoxy(62,16+z);printf("%s",identitas[a].alamat_jemput);
   		gotoxy(77,16+z);printf("%d",identitas[a].jumlah_orang);
   		gotoxy(92,16+z);printf("%s",jurus[a].jurusan);
	   	gotoxy(107,16+z);printf("%s",jurus[a].tanggal);
   		gotoxy(122,16+z);printf("%s",jurus[a].jam);
   		gotoxy(137,16+z);printf("%d",identitas[a].jumlah_bayar);
	      z+=2;
      }
   }
   if(pelanggan==0){
   	gotoxy(65,26);printf("   PELANGGAN BELUM ADA  ");
      gotoxy(65,27);printf("                        ");
      gotoxy(65,28);printf("  TEKAN 0 UNTUK KEMBALI ");
      while(true){
      	char s=getch();
         if(s=='0'){
         	desainpinggir();
         	menuawal();
         }
      }
   }else{
   	gotoxy(20,20+pelanggan*2);printf("1. ubah              ");
   	gotoxy(20,21+pelanggan*2);printf("2. hapus             ");
   	gotoxy(20,22+pelanggan*2);printf("3. menu awal         ");
      gotoxy(20,23+pelanggan*2);printf("Masukkan pilihan :   ");
      gotoxy(40,23+pelanggan*2);cin>>pilihan;
      if (strcmp(pilihan,"1")==0){
         edit();
   	}else if(strcmp(pilihan,"2")==0){
         hapus();
	   }else if(strcmp(pilihan,"3")==0){
      	menuawal();
	   }else{
   		gotoxy(20,26+pelanggan*2);printf("Invalid input");Sleep(1000);
      	lihat();
	   }
   }
}
////////////////////////////////////////////////////////////////////////////////
//                                                                            //
//                             VOID INFO JURUSAN                              //
//                                                                            //
////////////////////////////////////////////////////////////////////////////////
void infojurusan(){
   string tgl;
   desainpinggir();
   bck();
   batasdesain();
   textbackground(3);
   textcolor(4);
   gotoxy(6,16);cprintf("1. Pesan Travel");
   gotoxy(70,6);cprintf("KEBERANGKATAN UNTUK TANGGAL");
   gotoxy(73,8);cprintf("     %s", tggl);
	for(int a=1;a<=40;a++){
   	gotoxy(50+a,14);printf("%c",219);Sleep(6);
   	gotoxy(50+a,18);printf("%c",219);Sleep(6);
      gotoxy(50+a,34);printf("%c",219);Sleep(6);
      if(a<=20){
      	gotoxy(51,14+a);printf("%c",219);Sleep(6);
         gotoxy(55,14+a);printf("%c",219);Sleep(6);
         gotoxy(73,14+a);printf("%c",219);Sleep(6);
         gotoxy(83,14+a);printf("%c",219);Sleep(6);
   		gotoxy(90,14+a);printf("%c",219);Sleep(6);
      }
   }
   gotoxy(53,16);printf("No");
   gotoxy(57,16);printf("Jurusan");
   gotoxy(75,16);printf("Harga");
   gotoxy(85,16);printf("Stok");
   int aa=20;
   for(int b=0;b<5;b++){
   	gotoxy(53,aa);printf("%d",b+1);
   	gotoxy(57,aa);printf("%s",kota[b]);
   	gotoxy(75,aa);printf("%d",harga[b]);
   	gotoxy(85,aa);printf("%d",stok[b]);
      aa+=3;
   }
   char x[]="   *) Keberangkatan Khusus di Waktu Sore (16.30 WIB)  ";
      for (int a=0;a<strlen(x);a++){
      	 textcolor(7);
     		 gotoxy(a+43,36);cprintf("%c",x[a]);Sleep(32);
      }
   aa=20;
   gotoxy(43,38);printf("pilih 0 untuk kembali");
   o:
   gotoxy(95,25);cout<<"Masukkan No Pilihan : ";
   gotoxy(118,25);cin>>pilihan;
   if(strcmp(pilihan,"0")==0){
   	menuawal();
	}
   else if(strcmp(pilihan,"1")==0){
   	jur=kota[0];
      kode=0;
      inputpel();
	}else if(strcmp(pilihan,"2")==0){
  		jur=kota[1];
      //bayar=harga[1];
      kode=1;
      inputpel();
   }else if(strcmp(pilihan,"3")==0){
    	jur=kota[2];
      //bayar=harga[2];
      kode=2;
      inputpel();
   }else if(strcmp(pilihan,"4")==0){
    	jur=kota[3];
      //bayar=harga[3];
      kode=3;
      inputpel();
   }else if(strcmp(pilihan,"5")==0){
    	jur=kota[4];
      //bayar=harga[4];
      kode=4;
      inputpel();
   }else{
  		gotoxy(95,27);cout<<"Invalid Input";Sleep(1000);
      gotoxy(95,27);cout<<"             ";
      gotoxy(118,25);cout<<"            ";
      goto o;
   }
}
////////////////////////////////////////////////////////////////////////////////
//                                                                            //
//                       VOID INPUT PELANGGAN                                 //
//                                                                            //
////////////////////////////////////////////////////////////////////////////////
void inputpel(){
	bck();
   pembayaran pem;
	string nm,no,tmpt,almt;
   int jml;
   char jm[20];
   textbackground(3);
   textcolor(4);
   textcolor(14);
   gotoxy(39,4);cprintf("  TTTTTT  RRRRR      AA     NN   NN   SSSSS     AA    KK  KK  SSSSS  II  ");Sleep(1);
   gotoxy(39,5);cprintf("    TT    RR  RR   AA  AA   NNN  NN   SS      AA  AA  KK KK   SS     II  ");Sleep(1);
	gotoxy(39,6);cprintf("    TT    RRRR     AAAAAA   NN N NN   SSSSS   AAAAAA  KKK     SSSSS  II  ");Sleep(1);
	gotoxy(39,7);cprintf("    TT    RR  RR   AA  AA   NN  NNN       S   AA  AA  KK KK      SS  II  ");Sleep(1);
   gotoxy(39,8);cprintf("    TT    RR  RR   AA  AA   NN   NN   SSSSS   AA  AA  KK  KK  SSSSS  II  ");Sleep(1);
   for(int a=1;a<=150;a++){
   	gotoxy(2+a,10);printf("%c",219);
   }
   for(int a=1;a<=150;a++){
   	gotoxy(2+a,10);printf("%c",219);
   }
   gotoxy(9,14);printf("                          INPUT DATA                            ");
   for(int a=1;a<=63;a++){
   	if(a<15){
   		gotoxy(9,16+a);printf("@");
      	gotoxy(72,17+a);printf("@");
      }
      gotoxy(8+a,18);printf("@");
      gotoxy(8+a,30);printf("@");
   }
   textbackground(3);
   textcolor(7);
   gotoxy(12,20);cprintf("Masukkan nama lengkap   :                   ");
   gotoxy(12,22);cprintf("Masukkan no hp          :                   ");
   gotoxy(12,24);cprintf("Masukkan tempat tinggal :                   ");
   gotoxy(12,26);cprintf("Masukkan alamat jemput  :                   ");
   gotoxy(12,28);cprintf("Masukkan jumlah Orang   :                   ");
   textbackground(16);
   gotoxy(38,20);cprintf("                     ");
   gotoxy(38,22);cprintf("                     ");
   gotoxy(38,24);cprintf("                     ");
   gotoxy(38,26);cprintf("                     ");
   gotoxy(38,28);cprintf("                     ");
   textbackground(3);
   textcolor(7);
   gotoxy(39,20);cin>>nm;
   gotoxy(39,22);cin>>no;
   gotoxy(39,24);cin>>tmpt;
   gotoxy(39,26);cin>>almt;

   m:
   textbackground(16);
   gotoxy(38,28);cprintf("                     ");
   textbackground(3);
   textcolor(7);
   gotoxy(39,28);cin>>jm;

   int pi=0;
   for (int b=0;b<strlen(jm);b++){
   	if(jm[b]>='0' && jm[b]<='9'){
      	pi++;
      }
   }
   if(pi==strlen(jm)){
   	jml=atoi(jm);
   	if(jml>=10){
   		gotoxy(30,32);printf("Jumlah maks 10");Sleep(1000);
         textbackground(3);
   		textcolor(4);
  		   textcolor(14);
         gotoxy(30,32);cprintf("              ");
      	goto m;
   	}
      if(stok[kode]<jml){
        	gotoxy(30,32);printf("Jumlah stok tinggal %d ",stok[kode]);Sleep(1000);
         textbackground(3);
   		textcolor(4);
   		textcolor(14);
         gotoxy(30,32);cprintf("                       ");
     		goto m;
      }
   }else{
   	gotoxy(30,32);printf("Inputan harus angka");Sleep(600);
      textbackground(3);
   	textcolor(4);
      textcolor(14);
      gotoxy(30,32);cprintf("                   ");
      goto m;
   }
   gotoxy(87,14);printf("                       TRANSAKSI                     ");
   gotoxy(87,18);printf("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
   gotoxy(87,19);printf("XXX                                               XXX");
   gotoxy(87,20);printf("XXX   Total Harga : %d",harga[kode]*jml);printf("                         ");
   gotoxy(87,21);printf("XXX                                               XXX");
   gotoxy(87,22);printf("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
   gotoxy(137,20);printf("XXX");
   gotoxy(100,24);printf("Pilih :                    ");//Masukkan Pilihan : ";cin>>pilihan;
   gotoxy(100,25);printf("                           ");
   gotoxy(100,26);printf("1. Kirim                   ");
   gotoxy(100,27);printf("2. Batal                   ");

   while(true){
   	char aa=getch();
   	if (aa=='1'){
      	pelanggan+=1;
	      jurus[pelanggan-1].jurusan=jur;
   	   jurus[pelanggan-1].tanggal=tggl;
      	jurus[pelanggan-1].jam="16:30 WIB";
	      identitas[pelanggan-1].id=pelanggan;
   	   identitas[pelanggan-1].nama=nm;
      	identitas[pelanggan-1].no_hape=no;
	      identitas[pelanggan-1].tempat_tinggal=tmpt;
   	   identitas[pelanggan-1].alamat_jemput=almt;
      	identitas[pelanggan-1].jumlah_orang=jml;
	      identitas[pelanggan-1].jumlah_bayar=harga[kode]*jml;
         stok[kode]-=jml;
         pem.setharga(identitas[pelanggan-1].jumlah_bayar);
         char bay[20];
         n:
         gotoxy(112,30);printf("                     ");
         gotoxy(90,30);printf("Masukkan pembayaran : ");cin>>bay;
         int ben=0;
         int yar;
         for (int b=0;b<strlen(bay);b++){
	   		if(bay[b]>='0' && bay[b]<='9'){
   	   		ben++;
      		}
		   }
	   	if(ben==strlen(bay)){
   			yar=atoi(bay);
            if(yar==harga[kode]*jml){
            	gotoxy(90,32);printf("Uang Anda PASS!. Terima Kasih");
            }else if(yar<harga[kode]*jml){
	   			gotoxy(90,32);printf("Uang anda kurang, Masukan Jumlah Uang kembali");Sleep(500);
               gotoxy(90,32);printf("                                             ");
      			goto n;
	   		}else{
            	pem.setuang(yar);
         		gotoxy(90,32);cprintf("Kembalian anda : %d            ",pem.kembalian());
            }
   	  	}else{
	   		gotoxy(90,32);printf("         Inputan harus angka        ");Sleep(500);
            gotoxy(90,32);cprintf("                                    ");
	      	goto n;
   		}
            getch();
            menuawal();
      }else if(aa=='2'){
      	gotoxy(90,32);cout<<"Pesan dibatalkan !!!";Sleep(1000);
            menuawal();

      }
   }
}
////////////////////////////////////////////////////////////////////////////////
//                                                                            //
//                               VOID EDIT                                    //
//                                                                            //
////////////////////////////////////////////////////////////////////////////////
void edit(){
	pembayaran pem;
	int i;
   string tgl,jam,nm,no,tmpt,almt;
	int jml;
   int hargadulu;
   char jm[20],bay[20];
   gotoxy(45,24+pelanggan*2);printf("Masukkan id yang akan di edit : ");scanf("%d",&i);
   for(int a=0;a<pelanggan;a++){
   	if(i==identitas[a].id){
      	hargadulu=identitas[a].jumlah_bayar;
         if(jurus[a].jurusan=="Purwokerto"){
         	kode=0;
         }else if(jurus[a].jurusan=="Jakarta"){
         	kode=1;
         }else if(jurus[a].jurusan=="Garut"){
         	kode=2;
         }else if(jurus[a].jurusan=="Semarang"){
         	kode=3;
         }else if(jurus[a].jurusan=="Ciamis"){
         	kode=4;
         }
         stok[kode]+=identitas[a].jumlah_orang;
		   gotoxy(45,25+pelanggan*2);cout<<"Masukkan nama lengkap   : ";cin>>nm;
		   gotoxy(45,26+pelanggan*2);cout<<"Masukkan no hp          : ";cin>>no;
		   gotoxy(45,27+pelanggan*2);cout<<"Masukkan tempat tinggal : ";cin>>tmpt;
		   gotoxy(45,28+pelanggan*2);cout<<"Masukkan alamat jemput  : ";cin>>almt;
         m:
		   gotoxy(45,29+pelanggan*2);cout<<"Masukkan jumlah Orang   : ";cin>>jm;
         int pi=0;
		   for (int b=0;b<strlen(jm);b++){
   			if(jm[b]>='0' && jm[b]<='9'){
		      	pi++;
      		}
		   }
		   if(pi==strlen(jm)){
   			jml=atoi(jm);
		   	if(jml>=10){
   				gotoxy(45,31+pelanggan*2);printf("Jumlah maks 10 orang");
		      	goto m;
   			}
            if(stok[kode]<jml){
		        	gotoxy(45,32+pelanggan*2);printf("Jumlah stok tinggal %d ",stok[kode]);Sleep(1000);
      		   gotoxy(45,32+pelanggan*2);printf("                       ");
     				goto m;
		      }
		   }else{
   			gotoxy(45,31+pelanggan*2);printf("Inputan harus angka");
		      goto m;
		   }
	      identitas[a].nama=nm;
	      identitas[a].no_hape=no;
	      identitas[a].tempat_tinggal=tmpt;
	      identitas[a].alamat_jemput=almt;
	      identitas[a].jumlah_orang=jml;
	      identitas[a].jumlah_bayar=harga[kode]*jml;
         stok[kode]-=jml;
        gotoxy(47,31+pelanggan*2);printf("edit berhasil");Sleep(1000);
         if(identitas[a].jumlah_bayar<hargadulu){
         	gotoxy(90,26+pelanggan*2);cprintf("kembalian anda : %d           ",hargadulu-identitas[a].jumlah_bayar);
            getch();
            lihat();
         }else if(identitas[a].jumlah_bayar==hargadulu){
         	gotoxy(90,31+pelanggan*2);cprintf("Harga sama");
            getch();
            lihat();
         }else{
         	gotoxy(90,26+pelanggan*2);cprintf("Uang bayar anda kurang Rp : %d",identitas[a].jumlah_bayar-hargadulu);
            n:
	         gotoxy(90,28+pelanggan*2);printf("Masukkan pembayaran : ");cin>>bay;
   	      int ben=0;

      	   int yar;
         	for (int b=0;b<strlen(bay);b++){
	   			if(bay[b]>='0' && bay[b]<='9'){
   	   			ben++;
	      		}
			   }
	   		if(ben==strlen(bay)){
   				yar=atoi(bay);
            	if(yar==identitas[a].jumlah_bayar-hargadulu){
            		gotoxy(90,30+pelanggan*2);printf("Uang Anda PASS!. Terima Kasih");Sleep(1000);
	            }else if(yar<identitas[a].jumlah_bayar-hargadulu){
		   			gotoxy(90,30+pelanggan*2);printf("Uang anda kurang, lakukan lagi");Sleep(1000);
                  gotoxy(90,30+pelanggan*2);printf("                              ");
      				goto n;
	   			}else{
               	pem.setharga(identitas[a].jumlah_bayar-hargadulu);
            		pem.setuang(yar);
         			gotoxy(90,30+pelanggan*2);printf("Kembalian anda : %d",pem.kembalian());
                  getch();
	            }
   		  	}else{
	   			printf("Inputan harus angka");
	      		goto n;
	   		}
            lihat();
         }
      }
   }gotoxy(42,20+pelanggan*2);printf("id tidak ditemukan");Sleep(1000);
	lihat();
}
////////////////////////////////////////////////////////////////////////////////
//                                                                            //
//                                VOID HAPUS                                  //
//                                                                            //
////////////////////////////////////////////////////////////////////////////////
void hapus(){
	int h;
	gotoxy(42,21+pelanggan*2);printf("Masukkan id yang akan di hapus : ");scanf("%d",&h);
   for(int a=0;a<pelanggan;a++){
   	if(h==identitas[a].id){
	      identitas[a].id=0;
         gotoxy(44,23+pelanggan*2);printf("Hapus berhasil");Sleep(1000);
         lihat();
      }
   }
   gotoxy(44,23+pelanggan*2);printf("Id tidak ada");Sleep(1000);
   lihat();
}
////////////////////////////////////////////////////////////////////////////////
//                                                                            //
//                          VOID TAMBAH  ADMIN                                //
//                                                                            //
////////////////////////////////////////////////////////////////////////////////
void tambah(){
	string us,ps;
   gotoxy(55,16);printf("<<===== T A M B A H  A D M I N  ======<<");
   gotoxy(55,17);printf("                                        ");
   gotoxy(55,18);printf("       Masukkan Username :              ");
   gotoxy(55,19);printf("                                        ");
	gotoxy(55,20);printf("       Masukkan Password :              ");
   gotoxy(55,21);printf("                                        ");
   gotoxy(55,22);printf("________________________________________");

   textbackground(3);
  	//textcolor(15);
   gotoxy(6,23);cprintf("2. Tambah Admin");
   gotoxy(82,18);cin>>us;
   gotoxy(82,20);cin>>ps;

   gotoxy(55,24);printf("         T E K A N  N O M O R           ");
   gotoxy(55,25);printf("----------------------------------------");
   gotoxy(55,26);printf("               1 Kirim                  ");
   gotoxy(55,27);printf("               2 Batal                  ");
   while(true){
   	char a=getch();
      if(a=='1'){
         adm[dmin].user=us;
		   adm[dmin].pass=ps;
         dmin++;
         gotoxy(63,30);printf("  Tambah admin sukses !! ");Sleep(1000);
         login();
      }else if(a=='2'){
			gotoxy(63,30);printf("Tambah admin dibatalkan");Sleep(1000);
			menuawal();
      }
   }
}
////////////////////////////////////////////////////////////////////////////////
//                                                                            //
//                           VOID LOGIN                                       //
//                                                                            //
////////////////////////////////////////////////////////////////////////////////
void login(){
bck();
adm[0].user="kelompok";
adm[0].pass="rahasia";
   string p;
   string u,tgl;
   e:
   textbackground(3);
   textcolor(16);
   gotoxy(48, 8);cprintf("  000         0000      000000    000    000    00 ");
   gotoxy(48 ,9);cprintf("   00        00  00    00          00     000   00 ");
   gotoxy(48,10);cprintf("   00       00    00   00          00     00 0  00 ");
   gotoxy(48,11);cprintf("   00        00    00   00  0000    00     00  0 00 ");
   gotoxy(48,12);cprintf("   00    00  00  00    00    00    00     00   000 ");
   gotoxy(48,13);cprintf("   00000000   0000      000000     000    00    000");

   gotoxy(55,16);cout<<"<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<";
   gotoxy(55,17);cout<<"                                         ";
   gotoxy(55,18);cout<<"<<     Masukkan Username :             >>";
   gotoxy(55,19);cout<<"                                         ";
	gotoxy(55,20);cout<<">>     Masukkan Password :             <<";
   gotoxy(55,21);cout<<"                                         ";
   gotoxy(55,22);cout<<">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>";
   gotoxy(82,18);cin>>u;
   gotoxy(82,20);cin>>p;

   for(int a=0;a<dmin;a++){
   	if(u==adm[a].user && p==adm[a].pass){
         gotoxy(55,24);printf("            login sukses                 ");
      	gotoxy(55,26);printf("   Masukkan tanggal untuk keberangkatan: ");
         gotoxy(70,28);cin>>tgl;
		   tggl=tgl;
		   menuawal();
      }
   }gotoxy(55,24);printf("     Username atau passwaord salah       ");login();
   goto e;
}
main(){
 	//menuawal();
	logo();
   login();
getch();
}
