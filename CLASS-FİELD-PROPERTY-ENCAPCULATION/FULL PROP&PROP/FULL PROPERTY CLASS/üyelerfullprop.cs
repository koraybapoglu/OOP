using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace denemeclass
{
    internal class üyelerfullprop
    {
        string _ÜyeAdi;
        public string ÜyeAdi
        {
            get
            {
                return _ÜyeAdi;
            }
            set
            {
                _ÜyeAdi = value;
            }
        }
        string _ÜyeSoyadi;
        public string ÜyeSoyadi
        {
            get
            {
                return _ÜyeSoyadi;
            }
            set
            {
                _ÜyeSoyadi = value;
            }
        }
        //Burada yaptığımız olay OOP'nin kemik yapısıdır.Bir class'ta property ve field olmak zorundadır.Nesne Tabanlı Programlamada oluşturduğumuz Nesneler bu 'Nesne Şablonu'
        //içerisinden nesne olarak çıkmaktadırlar.Oluşturduğumuz classlar bir nesne değil nesne şablonudur.
        //ÖRNEK:TC KİMLİK NO:HERKESİN TC KİMLİĞİ AYNIDIR FAKAT İÇERİSİNDEKİ BİLGİLER FARKLIDIR.DÜZ ÜSTÜNDE HİÇBİR YAZI BULUNMAYAN TC KİMLİKLER BİRER NESNE ŞABLONU İKEN,
        //ÜSTÜNE VERİ YAZDIĞIMIZ TC_NO,ADI,SOYADI,DOĞUM TARİHİ VB. GİBİ VERİLER GELİNCE BİRER NESNE OLMAKTADIRLAR.BUNUDA NESNE ŞABLONU OLAN BOŞ TC KİMLİKLER İLE
        //SAĞLAMAKTADIRLAR.
        //**********************************************************************************************************************************************************************
        //FULL PROPERTY NEDİR ?
        //FULL PROPERTY GET VE SET METHODLARI AÇILMIŞ GELEN VERİYİ ENCAPSULATION(KAPSÜLLEME) İŞLEMİ YAPTIĞIMIZ PROPERTYLEDİR.
    }
}
