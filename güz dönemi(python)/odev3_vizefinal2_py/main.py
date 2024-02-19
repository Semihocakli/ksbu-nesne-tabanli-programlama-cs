import typing
from PyQt6.QtCore import *
from PyQt6.QtGui import *
from PyQt6.QtWidgets import *
from PyQt6 import QtCore, uic

import sys
from PyQt6.QtWidgets import QWidget

class Window(QWidget):
    def __init__(self):
        super().__init__()

        self.setGeometry(100, 100, 700, 520)
        self.setWindowTitle("vizefinal2")
        self.Widgets()
        self.kilitle1()
        
    def Widgets(self):
        # vize1 yüzdesi , vize2 yüzdesi , final yüzdesi labellar
        self.label_yuzdelikler = QLabel("Yüzdelikler", self)
        self.label_yuzdelikler.move(40, 15)
        self.label_yuzdelikler.setFont(QFont("Times", 15, QFont.Weight.Bold.value))
        self.label_vize1_yuzdesi = QLabel("Vize1 Yüzdesi:", self)
        self.label_vize1_yuzdesi.move(50, 50)
        self.label_vize2_yuzdesi = QLabel("Vize2 Yüzdesi:", self)
        self.label_vize2_yuzdesi.move(50, 90)
        self.label_final_yuzdesi = QLabel("Final Yüzdesi:", self)
        self.label_final_yuzdesi.move(50, 130)
        # vize1 , vize2 , final büt labellar
        self.label_sinavlar = QLabel("Sınavlar", self)
        self.label_sinavlar.move(50, 180)
        self.label_sinavlar.setFont(QFont("Times", 15, QFont.Weight.Bold.value))
        self.label_vize1 = QLabel("Vize1:", self)
        self.label_vize1.move(50, 220)
        self.label_vize2 = QLabel("Vize2:", self)
        self.label_vize2.move(50, 260)
        self.label_final = QLabel("Final:", self)
        self.label_final.move(50, 300)
        self.label_but = QLabel("Büt:", self)
        self.label_but.move(50, 340)
        # vize1 , vize2 , final yüzdeleri textboxları
        self.textbox_vize1_yuzdesi = QLineEdit(self)
        self.textbox_vize1_yuzdesi.move(150, 50)
        self.textbox_vize1_yuzdesi.resize(100, 20)
        self.textbox_vize2_yuzdesi = QLineEdit(self)
        self.textbox_vize2_yuzdesi.move(150, 90)
        self.textbox_vize2_yuzdesi.resize(100, 20)
        self.textbox_final_yuzdesi = QLineEdit(self)
        self.textbox_final_yuzdesi.move(150, 130)
        self.textbox_final_yuzdesi.resize(100, 20)
        # vize1 , vize2 , final , büt textboxları
        self.textbox_vize1 = QLineEdit(self)
        self.textbox_vize1.move(150, 220)
        self.textbox_vize1.resize(100, 20)
        self.textbox_vize2 = QLineEdit(self)
        self.textbox_vize2.move(150, 260)
        self.textbox_vize2.resize(100, 20)
        self.textbox_final = QLineEdit(self)
        self.textbox_final.move(150, 300)
        self.textbox_final.resize(100, 20)
        self.textbox_but = QLineEdit(self)
        self.textbox_but.move(150, 340)
        self.textbox_but.resize(100, 20)
        # temizle button 
        self.button_temizle = QPushButton("Temizle", self)
        self.button_temizle.move(50, 380)
        self.button_temizle.clicked.connect(self.temizle)
        # hesapla button
        self.button_hesapla = QPushButton("Hesapla", self)
        self.button_hesapla.move(150, 380)
        self.button_hesapla.clicked.connect(self.hesapla)
        # hesapla 2 button 
        self.button_hesapla2 = QPushButton("Hesapla2", self)
        self.button_hesapla2.move(150, 420)
        self.button_hesapla2.clicked.connect(self.hesapla2)
        # sonuc labelları
        self.label_ort = QLabel("Ortalama:", self)
        self.label_ort.move(350, 50)
        self.label_durum1 = QLabel("Durum1.....:", self)
        self.label_durum1.move(350, 90)
        self.label_durum2 = QLabel("Durum2......:", self)
        self.label_durum2.move(350, 130)
        self.label_harf = QLabel("Harf:", self)
        self.label_harf.move(350, 170)

    def temizle(self):
        self.textbox_vize1_yuzdesi.clear()
        self.textbox_vize2_yuzdesi.clear()
        self.textbox_final_yuzdesi.clear()
        self.textbox_vize1.clear()
        self.textbox_vize2.clear()
        self.textbox_final.clear()
        self.textbox_but.clear()
        self.textbox_but.setEnabled(False)
        self.button_hesapla2.setEnabled(False)
        self.textbox_vize1.setEnabled(True)
        self.textbox_vize2.setEnabled(True)
        self.textbox_final.setEnabled(True)
        self.textbox_final_yuzdesi.setEnabled(True)
        self.textbox_vize2_yuzdesi.setEnabled(True)
        self.textbox_vize1_yuzdesi.setEnabled(True)
        self.button_hesapla.setEnabled(True)
        self.label_durum1.setText("")
        self.label_durum2.setText("")
        self.label_harf.setText("")

    def hesapla2(self):
        vize1 = float(self.textbox_vize1.text())
        vize2 = float(self.textbox_vize2.text())
        büt = float(self.textbox_but.text())

        vize1_yuzdesi = float(self.textbox_vize1_yuzdesi.text())
        vize2_yuzdesi = float(self.textbox_vize2_yuzdesi.text())

        vize1_yuzde = vize1_yuzdesi / 100
        vize2_yuzde = vize2_yuzdesi / 100

        yeni_ort = vize1 * vize1_yuzde + vize2 * vize2_yuzde + büt * 0.5
        self.label_ort.setText(str(yeni_ort))

        if yeni_ort >= 60:
            self.label_durum2.setText("GECTİ")
            self.label_durum1.setText("")
        if 100 >= yeni_ort >= 90:
            self.label_harf.setText("AA")
        if 90 >= yeni_ort >= 80:
            self.label_harf.setText("BB")
        if 80 >= yeni_ort >= 70:
            self.label_harf.setText("CC")
        if 70 >= yeni_ort >= 60:
            self.label_harf.setText("DD")
        else:
            pass

    def kilitle1(self):
        self.textbox_but.setEnabled(False)
        self.button_hesapla2.setEnabled(False)
    
    def hesapla(self):
        if self.hatalar() == -1:
            return -1
        
        vize1yuzdesi = float(self.textbox_vize1_yuzdesi.text())
        vize2yuzdesi = float(self.textbox_vize2_yuzdesi.text())
        finalyuzdesi = float(self.textbox_final_yuzdesi.text())

        vize1 = float(self.textbox_vize1.text())
        vize2 = float(self.textbox_vize2.text())
        final = float(self.textbox_final.text())

        vize1yuzde = vize1yuzdesi / 100
        vize2yuzde = vize2yuzdesi / 100
        finalyuzde = finalyuzdesi / 100

        vize1sonuc = vize1 * vize1yuzde
        vize2sonuc = vize2 * vize2yuzde
        finalsonuc = final * finalyuzde
        ort = float(vize1sonuc + vize2sonuc + finalsonuc)

        self.label_ort.setText(str(ort))

        if ort >= 60:
            self.label_durum2.setText("GECTİ")
        if 100 >= ort >= 90:
            self.label_harf.setText("AA")
        elif 90 >= ort >= 80:
            self.label_harf.setText("BB")
        elif 80 >= ort >= 70:
            self.label_harf.setText("CC")
        elif 70 >= ort >= 60:
            self.label_harf.setText("DD")
        else:
            self.label_durum2.setText("KALDI")
            self.label_harf.setText("FF")
            self.label_durum1.setText("Büt Sınavına Giriniz")
            self.textbox_but.setEnabled(True)
            self.button_hesapla2.setEnabled(True)
            self.button_hesapla.setEnabled(False)
            self.textbox_vize1.setEnabled(False)
            self.textbox_vize2.setEnabled(False)
            self.textbox_final.setEnabled(False)
            self.textbox_final_yuzdesi.setEnabled(False)
            self.textbox_vize2_yuzdesi.setEnabled(False)
            self.textbox_vize1_yuzdesi.setEnabled(False)
            
    def hatalar(self):
        if self.textbox_vize1_yuzdesi.text() == "" or self.textbox_vize2_yuzdesi.text() == "" or self.textbox_final_yuzdesi.text() == "":
            QMessageBox.critical(self, "Hata1", "Lütfen Yüzdelikleri Giriniz")
            return -1
        
        vize1_yuzdesi = float(self.textbox_vize1_yuzdesi.text())
        vize2_yuzdesi = float(self.textbox_vize2_yuzdesi.text())
        final_yuzdesi = float(self.textbox_final_yuzdesi.text())
        toplam_yuzde = float(vize1_yuzdesi + vize2_yuzdesi + final_yuzdesi)

        if vize1_yuzdesi < 0 or vize1_yuzdesi > 100 or vize2_yuzdesi < 0 or vize2_yuzdesi > 100 or final_yuzdesi < 0 or final_yuzdesi > 100:
            QMessageBox.critical(self, "Hata2", "Lütfen 0-100 arasında sayı giriniz.")
            return -1
        
        if toplam_yuzde > 100:
            QMessageBox.critical(self, "Hata3", "Toplam yüzdelik 100'den fazla olamaz")
            return -1

        if float(self.textbox_final_yuzdesi.text()) <= 49:
            QMessageBox.critical(self, "Hata4", "Final yüzdesi 50'den küçük olamaz")
            return -1


if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = Window()
    window.show()
    sys.exit(app.exec())