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
        
        self.setGeometry(100, 100, 600, 350)
        self.setWindowTitle("taksit1")
        self.Widgets()
        self.Layout()

    def Widgets(self):
        # labellar
        self.label1 = QLabel("Ürün Fiyati",self)
        self.label1.move(40,40)
        self.label2 = QLabel("Ürün Adedi",self)
        self.label2.move(40,80)
        self.label3 = QLabel("Ürün Fiyatı:",self)
        self.label3.move(400,120)
        self.label4 = QLabel("Ürün Adedi:",self)
        self.label4.move(400,160)
        self.label5 = QLabel("Toplam Ödeme:",self)
        self.label5.move(400,200)
        self.label6 = QLabel("Aylık Ödeme:",self)
        self.label6.move(400,240)

        self.label7 = QLabel("...........:",self)
        self.label7.move(500,120)
        self.label8 = QLabel("...........:",self)
        self.label8.move(500,160)
        self.label9 = QLabel("...........:",self)
        self.label9.move(500,200)
        self.label10 = QLabel("...........♦:",self)
        self.label10.move(500,240)

        # textboxlar
        self.textbox1 = QLineEdit(self)
        self.textbox1.move(120,40)
        self.textbox1.resize(100,20)
        self.textbox2 = QLineEdit(self)
        self.textbox2.move(120,80)
        self.textbox2.resize(100,20)

        # radiobuttonlar
        self.radioButton1 = QRadioButton("2 taksit",self)
        self.radioButton2 = QRadioButton("3 taksit",self)
        self.radioButton3 = QRadioButton("4 taksit",self)
        self.radioButton4 = QRadioButton("5 taksit",self)
        self.radioButton5 = QRadioButton("6 taksit",self)
        self.radioButton6 = QRadioButton("8 taksit",self)
        self.radioButton7 = QRadioButton("10 taksit",self)
        self.radioButton8 = QRadioButton("12 taksit",self)

        # groupbox
        self.groupBox = QGroupBox("taksitler",self)
        self.groupBox.move(40,120)
        self.groupBox.resize(300,200)
       
        # hesapla buton
        self.button1 = QPushButton("Hesapla",self)
        self.button1.move(450,300)
        self.button1.clicked.connect(self.button1_clicked)
        
        # temizle buton
        self.button2 = QPushButton("Temizle",self)
        self.button2.move(350,40)
        self.button2.clicked.connect(self.temizle)

        # çıkış buton
        self.button3 = QPushButton("Çıkış",self)
        self.button3.move(450,40)
        self.button3.clicked.connect(self.close)

    def Layout(self):
        vbox = QVBoxLayout(self.groupBox)
        hbox1 = QHBoxLayout()
        hbox2 = QHBoxLayout()

        hbox1.addWidget(self.radioButton1)
        hbox1.addWidget(self.radioButton2)
        hbox1.addWidget(self.radioButton3)
        hbox1.addWidget(self.radioButton4)

        hbox2.addWidget(self.radioButton5)
        hbox2.addWidget(self.radioButton6)
        hbox2.addWidget(self.radioButton7)
        hbox2.addWidget(self.radioButton8)

        vbox.addLayout(hbox1)
        vbox.addLayout(hbox2)

        self.groupBox.setLayout(vbox)

    def button1_clicked(self): # 7  8 9 10
        
        ürünFiyati = float(self.textbox1.text())
        ürünAdedi = float(self.textbox2.text())
        toplamÖdeme = ürünFiyati * ürünAdedi

        self.label7.setText(str(toplamÖdeme))
        self.label8.setText(str(ürünAdedi))


        if self.radioButton1.isChecked():
            taksitli2 = (toplamÖdeme + (toplamÖdeme * 0.02))
            self.label9.setText(str(taksitli2))
            aylik2 = taksitli2 / 2
            self.label10.setText(str(aylik2))

        if self.radioButton2.isChecked():
            taksitli3 = (toplamÖdeme + (toplamÖdeme * 0.04))
            self.label9.setText(str(taksitli3))
            aylik3 = taksitli3 / 3
            self.label10.setText(str(aylik3))

        if self.radioButton3.isChecked():
            taksitli4 = (toplamÖdeme + (toplamÖdeme * 0.06))
            self.label9.setText(str(taksitli4))
            aylik4 = taksitli4 / 4
            self.label10.setText(str(aylik4))
        
        if self.radioButton4.isChecked():
            taksitli5 = (toplamÖdeme + (toplamÖdeme * 0.08))
            self.label9.setText(str(taksitli5))
            aylik5 = taksitli5 / 5
            self.label10.setText(str(aylik5))

        if self.radioButton5.isChecked():
            taksitli6 = (toplamÖdeme + (toplamÖdeme * 0.10))
            self.label9.setText(str(taksitli6))
            aylik6 = taksitli6 / 6
            self.label10.setText(str(aylik6))

        if self.radioButton6.isChecked():
            taksitli8 = (toplamÖdeme + (toplamÖdeme * 0.12))
            self.label9.setText(str(taksitli8))
            aylik8 = taksitli8 / 8
            self.label10.setText(str(aylik8))

        if self.radioButton7.isChecked():
            taksitli10 = (toplamÖdeme + (toplamÖdeme * 0.14))
            self.label9.setText(str(taksitli10))
            aylik10 = taksitli10 / 10
            self.label10.setText(str(aylik10))

        if self.radioButton8.isChecked():
            taksitli12 = (toplamÖdeme + (toplamÖdeme * 0.16))
            self.label9.setText(str(taksitli12))
            aylik12 = taksitli12 / 12
            self.label10.setText(str(aylik12))

    def temizle(self):
        self.textbox1.clear()
        self.textbox2.clear()
        self.label7.setText("......")
        self.label8.setText("......")
        self.label9.setText("......")
        self.label10.setText("......")
        self.radioButton1.setChecked(False)
        self.radioButton2.setChecked(False)
        self.radioButton3.setChecked(False)
        self.radioButton4.setChecked(False)
        self.radioButton5.setChecked(False)
        self.radioButton6.setChecked(False)
        self.radioButton7.setChecked(False)
        self.radioButton8.setChecked(False)

if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = Window()
    window.show()
    sys.exit(app.exec())