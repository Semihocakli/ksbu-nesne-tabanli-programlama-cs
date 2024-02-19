import typing
from PyQt6 import QtCore, QtGui, QtWidgets
from PyQt6.QtCore import *
from PyQt6.QtGui import *
from PyQt6.QtWidgets import *
from PyQt6 import uic
import sys

from PyQt6.QtWidgets import QWidget

class Window(QWidget):
    def __init__(self):
        super().__init__()

        self.setGeometry(100, 100, 700, 300)
        self.setWindowTitle("Vize Final Hesaplama")
        self.Widgets()
        
    def Widgets(self):
        # sayi1,sayi2,sonuc,sonislemler,hepsi label
        self.label_sayi1 = QLabel("Sayi1:", self)
        self.label_sayi1.move(40, 40)
        self.label_sayi2 = QLabel("Sayi2:", self)
        self.label_sayi2.move(40, 80)
        self.label_sonuc = QLabel("Sonuc:", self)
        self.label_sonuc.move(40, 250)
        self.label_sonislemler = QLabel("Listbox(Son İşlemler)", self)
        self.label_sonislemler.move(300, 270)
        self.label_hepsi = QLabel("Listbox(Hepsi)", self)
        self.label_hepsi.move(500, 270)

        # sayi1,sayi2 textbox
        self.textbox_sayi1 = QLineEdit(self)
        self.textbox_sayi1.move(100, 40)
        self.textbox_sayi1.resize(100, 20)
        self.textbox_sayi2 = QLineEdit(self)
        self.textbox_sayi2.move(100, 80)
        self.textbox_sayi2.resize(100, 20)

        # topla,cikar,carp,bol checkbox
        self.checkbox_topla = QCheckBox("Topla", self)
        self.checkbox_topla.move(100, 120)
        self.checkbox_cikar = QCheckBox("Cikarma", self)
        self.checkbox_cikar.move(100, 150)
        self.checkbox_carp = QCheckBox("Carpma", self)
        self.checkbox_carp.move(100, 180)
        self.checkbox_bol = QCheckBox("Bolme", self)
        self.checkbox_bol.move(100, 210)

        # listbox1(sonişlemler) ve listbox2(hepsi)
        self.listbox1 = QListWidget(self)
        self.listbox1.move(300, 20)
        self.listbox1.resize(150, 250)
        self.listbox2 = QListWidget(self)
        self.listbox2.move(500, 20)
        self.listbox2.resize(150, 250)

        # hesapla button1
        self.button1 = QPushButton("Hesapla", self)
        self.button1.move(200, 120)
        self.button1.clicked.connect(self.buton1_click)

        # temizle button2
        self.button2 = QPushButton("Temizle", self)
        self.button2.move(200, 160)
        self.button2.clicked.connect(self.buton2_click)

        # kapat button3
        self.button3 = QPushButton("Kapat", self)
        self.button3.move(200, 200)
        self.button3.clicked.connect(self.close)

    def buton1_click(self):
        sayi1 = float(self.textbox_sayi1.text())
        sayi2 = float(self.textbox_sayi2.text())

        topla = sayi1 + sayi2
        cikar = sayi1 - sayi2
        carp = sayi1 * sayi2
        bol = sayi1 / sayi2

        carpma = f"{sayi1} * {sayi2} = {carp}" 
        bolme = f"{sayi1} / {sayi2} = {bol}"
        toplama = f"{sayi1} + {sayi2} = {topla}"
        cikarma = f"{sayi1} - {sayi2} = {cikar}"

        if self.checkbox_topla.isChecked():
            self.listbox1.clear()
            self.listbox1.addItem(toplama)
            self.listbox2.addItem(toplama)
            self.checkbox_topla.setChecked(False)
        
        if self.checkbox_cikar.isChecked():
            self.listbox1.clear()
            self.listbox1.addItem(cikarma)
            self.listbox2.addItem(cikarma)
            self.checkbox_cikar.setChecked(False)

        if self.checkbox_carp.isChecked():
            self.listbox1.clear()
            self.listbox1.addItem(carpma)
            self.listbox2.addItem(carpma)
            self.checkbox_carp.setChecked(False)

        if self.checkbox_bol.isChecked():
            self.listbox1.clear()
            self.listbox1.addItem(bolme)
            self.listbox2.addItem(bolme)
            self.checkbox_bol.setChecked(False)

    def buton2_click(self):
        self.listbox1.clear()
        self.listbox2.clear()
        self.textbox_sayi1.clear()
        self.textbox_sayi2.clear()
        self.checkbox_bol.setChecked(False)
        self.checkbox_carp.setChecked(False)
        self.checkbox_cikar.setChecked(False)
        self.checkbox_topla.setChecked(False)



if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = Window()
    window.show()
    sys.exit(app.exec())
