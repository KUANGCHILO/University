#include "seven.h"
class W6 //類別class
{ private:
  public:
    int i;
    void print7s(char val)
    {if (val=='0'){zero();}
     if (val=='1'){a03281();}
     if (val=='2'){a03282();}
     if (val=='3'){a03283();}
     if (val=='4'){a03284();}
     if (val=='5'){a03285();}
     if (val=='6'){a03286();}
     if (val=='7'){a03287();}
     if (val=='8'){for(this->i=1;this->i<8;this->i++){
      this->print7s(48+this->i);
      delay(100);}}
     if (val=='9'){nine();}
    }
};
W6 w6;
volatile int inByte=0;   
void setup() 
{
      init7();              //呼叫副程式(subroutine) ==請建附錄"init"
      Serial.begin(9600);
}
void loop() 
{  
  if(Serial.available()>0){ //問nano伴有串列值經由電腦送過來
    inByte = Serial.read(); //串列的值 用read放到inByte
    w6.print7s(inByte);
    delay(400); 
  }  //輸入1就顯示特定圖案
}
//    for(w6.i=0;w6.i<=9;w6.i++)
//     {w6.print7s(48+w6.i);
//      delay(300);
//      }    //要放進void loop才能用 功能:讓七節碼亮1~9
