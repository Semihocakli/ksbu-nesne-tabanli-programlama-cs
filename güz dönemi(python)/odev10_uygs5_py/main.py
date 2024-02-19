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

        self.setGeometry(100, 100, 600, 400)
        self.setWindowTitle("uygs5_quiz")
        self.Widgets()

    def Widgets(self):
        # labellar
        self.label = QLabel("Nakit/Taksitli Ürün Hesaplama Programı",self)
        self.label.move(50,10) 
        self.ürünfiyat = QLabel("Ürün Fiyatı",self)
        self.ürünfiyat.move(50,50)
        self.ader = QLabel("Adet",self)
        self.ader.move(50,80)
        # ödeme labelları
        self.label1 = QLabel("LABEL1..........",self)
        self.label1.move(480,130)
        self.label2 = QLabel("LABEL2............",self)
        self.label2.move(480,160)
        self.label3 = QLabel("LABEL3.............",self)
        self.label3.move(480,190)
        self.label4 = QLabel("LABEL4..............",self)
        self.label4.move(480,220)
        # lineeditler
        self.lineedit1 = QLineEdit(self)
        self.lineedit1.move(150,50)
        self.lineedit1.resize(100,20)
        self.lineedit2 = QLineEdit(self)
        self.lineedit2.move(150,80)
        self.lineedit2.resize(100,20)
        # radiobuttonlar
        self.radiobutton1 = QRadioButton("Nakit(%10 indirim)",self)
        self.radiobutton2 = QRadioButton("(KK) Taksitsiz",self)

        self.radiobutton3 = QRadioButton("2 Taksit(%10)",self)
        self.radiobutton4 = QRadioButton("3 Taksit(%20)",self)

        self.radiobutton5 = QRadioButton("+2 Ek Taksit (+ %10 ekle)",self)
        self.radiobutton6 = QRadioButton("+4 Ek Taksit (+ %20 ekle)",self)
        # grupboxlar
        self.grupbox1 = QGroupBox("Ödeme türü 1-2",self)
        self.grupbox1.move(50,120)
        self.grupbox1.resize(350,50)
        self.grupbox2 = QGroupBox("Ödeme türü 3-4",self)
        self.grupbox2.move(50,180)
        self.grupbox2.resize(350,50)
        self.groupbox3 = QGroupBox("Ödeme türü 5-6",self)
        self.groupbox3.move(50,240)
        self.groupbox3.resize(350,50)
        # butonlar
        self.buton1 = QPushButton("Hesapla",self)
        self.buton1.move(250,300)
        self.buton1.clicked.connect(self.hesapla)

        self.buton2 = QPushButton("Temizle",self)
        self.buton2.move(150,300)
        self.buton2.clicked.connect(self.temizle)

        self.buton3 = QPushButton("Kapat",self)
        self.buton3.move(50,300)
        self.buton3.clicked.connect(self.kapat)
        # layout 
        self.grupbox1_layout = QHBoxLayout(self.grupbox1)
        self.grupbox1_layout.addWidget(self.radiobutton1)
        self.grupbox1_layout.addWidget(self.radiobutton2)

        self.grupbox2_layout = QHBoxLayout(self.grupbox2)
        self.grupbox2_layout.addWidget(self.radiobutton3)
        self.grupbox2_layout.addWidget(self.radiobutton4)

        self.grupbox3_layout = QHBoxLayout(self.groupbox3)
        self.grupbox3_layout.addWidget(self.radiobutton5)
        self.grupbox3_layout.addWidget(self.radiobutton6)
        
    def hesapla(self):
        if self.hata1() == -1:
            self.lineedit1.setFocus()
            return
        self.calculate()
        self.lineedit1.setFocus()

    def hata1(self):
        if self.lineedit1.text() == "" or self.lineedit2.text() == "":
            QMessageBox.warning(self, "Hata", "H1: Fiyatı / Ürün Adeti Giriniz")
            return -1
        if not self.radiobutton1.isChecked() and not self.radiobutton2.isChecked():
            QMessageBox.warning(self, "Hata", "H2: Nakit / KK Seçin")
            return -1
        if self.radiobutton2.isChecked() and not self.radiobutton3.isChecked() and not self.radiobutton4.isChecked() and (self.radiobutton5.isChecked() or self.radiobutton6.isChecked()):
            QMessageBox.warning(self, "Hata", "H3: Ek Taksit için Taksit Seçin")
            return -1
        if self.radiobutton1.isChecked() and (self.radiobutton3.isChecked() or self.radiobutton4.isChecked()):
            QMessageBox.warning(self, "Hata", "H4: Nakit de Taksit Seçmeyin")
            return -1
        if self.radiobutton1.isChecked() and (self.radiobutton5.isChecked() or self.radiobutton6.isChecked()):
            QMessageBox.warning(self, "Hata", "H5: Nakit de Ek Taksit Seçmeyin")
            return -1
        return 0

    def calculate(self):
        s1 = int(self.lineedit1.text())
        s2 = int(self.lineedit2.text())
        top = s1 * s2
        oran = 0.0
        tt = 0.0
        ts = 1
        if self.radiobutton1.isChecked():
            oran = -10.0
        if self.radiobutton2.isChecked() and not self.radiobutton3.isChecked() and not self.radiobutton4.isChecked() and not self.radiobutton5.isChecked() and not self.radiobutton6.isChecked():
            oran = 0.0
            ts = 1
        if self.radiobutton2.isChecked() and self.radiobutton3.isChecked():
            oran = 10.0
            ts = 2
        if self.radiobutton2.isChecked() and self.radiobutton4.isChecked():
            oran = 20.0
            ts = 3
        if self.radiobutton5.isChecked():
            oran += 10.0
            ts += 2
        if self.radiobutton6.isChecked():
            oran += 20.0
            ts += 4
        top += top * oran / 100.0
        tt = round(top / ts, 2)
        self.label1.setText(str(top))
        self.label2.setText(str(tt))
        self.label3.setText(str(ts))
        self.label4.setText(str(oran))

    def temizle(self):
        self.temizle1()
        self.radiobutton1.setChecked(False)
        self.radiobutton2.setChecked(False)
        self.radiobutton3.setChecked(False)
        self.radiobutton4.setChecked(False)
        self.radiobutton5.setChecked(False)
        self.radiobutton6.setChecked(False)

    def temizle1(self):
        self.lineedit1.clear()
        self.lineedit2.clear()
        self.label1.clear()
        self.label2.clear()
        self.label3.clear()

    def kapat(self):
        self.close()


if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = Window()
    window.show()
    sys.exit(app.exec())