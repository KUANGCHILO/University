#include "seven.h"
#include "Arduino.h"

void one(void)
{  digitalWrite(a,off);digitalWrite(b,on);digitalWrite(c7,on);digitalWrite(d,off);
   digitalWrite(e,off);digitalWrite(f,off);digitalWrite(g,off);  
}
void two(void)
{  digitalWrite(a,on);digitalWrite(b,on);digitalWrite(c7,off);digitalWrite(d,on);
   digitalWrite(e,on);digitalWrite(f,off);digitalWrite(g,on);  
}
void init7(void)   //副程式的本體 (站記憶體)名字init void不回傳   init(void)不接收參數 initialize初始化
{ pinMode(a,OUTPUT);pinMode(b,OUTPUT); pinMode(c7,OUTPUT);pinMode(d,OUTPUT);
  pinMode(e,OUTPUT);pinMode(f,OUTPUT);pinMode(g,OUTPUT);
}
void zero(void)
{  digitalWrite(a,on);digitalWrite(b,on);digitalWrite(c7,on);digitalWrite(d,on);
   digitalWrite(e,on);digitalWrite(f,on);digitalWrite(g,off);  
}
void three(void)
{  digitalWrite(a,on);digitalWrite(b,on);digitalWrite(c7,on);digitalWrite(d,on);
   digitalWrite(e,off);digitalWrite(f,off);digitalWrite(g,on);  
}
void four(void)
{  digitalWrite(a,off);digitalWrite(b,on);digitalWrite(c7,on);digitalWrite(d,off);
   digitalWrite(e,off);digitalWrite(f,on);digitalWrite(g,on);  
}
void five(void)
{  digitalWrite(a,on);digitalWrite(b,off);digitalWrite(c7,on);digitalWrite(d,on);
   digitalWrite(e,off);digitalWrite(f,on);digitalWrite(g,on);  
}
void six(void)
{  digitalWrite(a,on);digitalWrite(b,off);digitalWrite(c7,on);digitalWrite(d,on);
   digitalWrite(e,on);digitalWrite(f,on);digitalWrite(g,on);  
}
void seven(void)
{  digitalWrite(a,on);digitalWrite(b,on);digitalWrite(c7,on);digitalWrite(d,off);
   digitalWrite(e,off);digitalWrite(f,on);digitalWrite(g,off);  
}
void eight(void)
{  digitalWrite(a,on);digitalWrite(b,on);digitalWrite(c7,on);digitalWrite(d,on);
   digitalWrite(e,on);digitalWrite(f,on);digitalWrite(g,on);  
}
void nine(void)
{  digitalWrite(a,on);digitalWrite(b,on);digitalWrite(c7,on);digitalWrite(d,on);
   digitalWrite(e,off);digitalWrite(f,on);digitalWrite(g,on);  
}
void A88(void)
{  digitalWrite(a,on);digitalWrite(b,on);digitalWrite(c7,on);digitalWrite(d,off);
   digitalWrite(e,on);digitalWrite(f,on);digitalWrite(g,on);  
}
void C88(void)
{  digitalWrite(a,off);digitalWrite(b,off);digitalWrite(c7,off);digitalWrite(d,on);
   digitalWrite(e,on);digitalWrite(f,off);digitalWrite(g,on);  
}
void B88(void)
{  digitalWrite(a,off);digitalWrite(b,off);digitalWrite(c7,on);digitalWrite(d,on);
   digitalWrite(e,on);digitalWrite(f,on);digitalWrite(g,on);  
}
void D88(void)
{  digitalWrite(a,off);digitalWrite(b,on);digitalWrite(c7,on);digitalWrite(d,on);
   digitalWrite(e,on);digitalWrite(f,off);digitalWrite(g,on);  
}
void E88(void)
{  digitalWrite(a,on);digitalWrite(b,off);digitalWrite(c7,off);digitalWrite(d,on);
   digitalWrite(e,on);digitalWrite(f,on);digitalWrite(g,on);  
}
void F88(void)
{  digitalWrite(a,on);digitalWrite(b,off);digitalWrite(c7,off);digitalWrite(d,off);
   digitalWrite(e,on);digitalWrite(f,on);digitalWrite(g,on);  
}
void d0321a(void)
{  digitalWrite(a,on);digitalWrite(b,on);digitalWrite(c7,off);digitalWrite(d,off);
   digitalWrite(e,off);digitalWrite(f,off);digitalWrite(g,off);  
}
void d0321b(void)
{  digitalWrite(a,off);digitalWrite(b,off);digitalWrite(c7,on);digitalWrite(d,on);
   digitalWrite(e,off);digitalWrite(f,off);digitalWrite(g,off);  
}
void d0321c(void)
{  digitalWrite(a,off);digitalWrite(b,off);digitalWrite(c7,off);digitalWrite(d,on);
   digitalWrite(e,on);digitalWrite(f,off);digitalWrite(g,off);  
}
void d0321d(void)
{  digitalWrite(a,on);digitalWrite(b,off);digitalWrite(c7,off);digitalWrite(d,off);
   digitalWrite(e,off);digitalWrite(f,on);digitalWrite(g,off);  
}
void d0321e(void)
{   
    d0321a();
    delay(100);
    d0321b();
    delay(100);
    d0321c();
    delay(100);
    d0321d();
    delay(100);
}
void a03281(void)
{  digitalWrite(a,on);digitalWrite(b,off);digitalWrite(c7,off);digitalWrite(d,off);
   digitalWrite(e,off);digitalWrite(f,off);digitalWrite(g,off);  
}
void a03282(void)
{  digitalWrite(a,off);digitalWrite(b,on);digitalWrite(c7,off);digitalWrite(d,off);
   digitalWrite(e,off);digitalWrite(f,off);digitalWrite(g,off);  
}
void a03283(void)
{  digitalWrite(a,off);digitalWrite(b,off);digitalWrite(c7,on);digitalWrite(d,off);
   digitalWrite(e,off);digitalWrite(f,off);digitalWrite(g,off);  
}
void a03284(void)
{  digitalWrite(a,off);digitalWrite(b,off);digitalWrite(c7,off);digitalWrite(d,on);
   digitalWrite(e,off);digitalWrite(f,off);digitalWrite(g,off);  
}
void a03285(void)
{  digitalWrite(a,off);digitalWrite(b,off);digitalWrite(c7,off);digitalWrite(d,off);
   digitalWrite(e,on);digitalWrite(f,off);digitalWrite(g,off);  
}
void a03286(void)
{  digitalWrite(a,off);digitalWrite(b,off);digitalWrite(c7,off);digitalWrite(d,off);
   digitalWrite(e,off);digitalWrite(f,on);digitalWrite(g,off);  
}
void a03287(void)
{  digitalWrite(a,off);digitalWrite(b,off);digitalWrite(c7,off);digitalWrite(d,off);
   digitalWrite(e,off);digitalWrite(f,off);digitalWrite(g,on);  
}
//int u
//void a03288(void)
//{    for(i=0;i<8;i++){
//      "a0328"+"i"()
//      delay(100); 
//}
