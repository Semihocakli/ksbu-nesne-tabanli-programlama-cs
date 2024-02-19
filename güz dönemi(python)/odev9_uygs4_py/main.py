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

        self.setGeometry(100, 100, 800, 350)
        self.setWindowTitle("uygs4_quiz")
        self.Widgets()

    def Widgets(self):
        # üst labellar
        self.label1 = QLabel("Ürün",self)
        self.label1.move(50,20)
        self.label2 = QLabel("İçecek",self)
        self.label2.move(50,160)
        self.label3 = QLabel("1.Ürün Adet",self)
        self.label3.move(250,20)
        self.label4 = QLabel("2.Ürün Adet",self)
        self.label4.move(350,20)
        self.label5 = QLabel("3.Ürün Adet",self)
        self.label5.move(450,20)
        # alt labellar
        self.label6 = QLabel("1.İçecek Adet",self)
        self.label6.move(250,160)
        self.label7 = QLabel("2.İçecek Adet",self)
        self.label7.move(350,160)
        self.label8 = QLabel("3.İçecek Adet",self)
        self.label8.move(450,160)
        # büyük label 
        self.label9 = QLabel("Siparis ve Toplam Tutar",self)
        self.label9.move(580,20)
        self.label10 = QLabel("İcecek Secmek Zorunda Değil",self)
        self.label10.move(40,270)
        # listbox1 
        self.listbox1 = QListWidget(self)
        self.listbox1.move(40,40)
        self.listbox1.resize(150,80)
        self.listbox1.addItem("Kücük Boy Pizza(50TL)")
        self.listbox1.addItem("Orta Boy Pizza(100TL)")
        self.listbox1.addItem("Büyük Boy Pizza(150TL)")
        # listbox2
        self.listbox2 = QListWidget(self)
        self.listbox2.move(40,180)
        self.listbox2.resize(150,80)
        self.listbox2.addItem("Kola(30TL)")
        self.listbox2.addItem("Fanta(20TL)")
        self.listbox2.addItem("Ayran(10TL)")
        # üst listboxlar
        self.listbox3 = QListWidget(self)
        self.listbox3.move(250,40)
        self.listbox3.resize(80,80)
        self.listbox3.addItem("1")
        self.listbox3.addItem("2")
        self.listbox3.addItem("3")
        self.listbox4 = QListWidget(self)
        self.listbox4.move(350,40)
        self.listbox4.resize(80,80)
        self.listbox4.addItem("1")
        self.listbox4.addItem("2")
        self.listbox4.addItem("3")
        self.listbox5 = QListWidget(self)
        self.listbox5.move(450,40)
        self.listbox5.resize(80,80)
        self.listbox5.addItem("1")
        self.listbox5.addItem("2")
        self.listbox5.addItem("3")
        # alt listboxlar
        self.listbox6 = QListWidget(self)
        self.listbox6.move(250,180)
        self.listbox6.resize(80,80)
        self.listbox6.addItem("1")
        self.listbox6.addItem("2")
        self.listbox6.addItem("3")
        self.listbox7 = QListWidget(self)
        self.listbox7.move(350,180)
        self.listbox7.resize(80,80)
        self.listbox7.addItem("1")
        self.listbox7.addItem("2")
        self.listbox7.addItem("3")
        self.listbox8 = QListWidget(self)
        self.listbox8.move(450,180)
        self.listbox8.resize(80,80)
        self.listbox8.addItem("1")
        self.listbox8.addItem("2")
        self.listbox8.addItem("3")
        # büyük listbox 
        self.listbox9 = QListWidget(self)
        self.listbox9.move(580,40)
        self.listbox9.resize(200,220)
        # butonlar
        self.button1 = QPushButton("Kapat",self)
        self.button1.move(250,300)
        self.button1.clicked.connect(self.close)

        self.button2 = QPushButton("Temizle",self)
        self.button2.move(350,300)
        self.button2.clicked.connect(self.temizle)

        self.button3 = QPushButton("Siparis Ver",self)
        self.button3.move(450,300)
        # self.button3.clicked.connect(self.hata)
        self.button3.clicked.connect(self.hesapla)
        # self.button3.clicked.connect(self.yaz)
    
    def yaz(self):
          if self.listbox1.currentItem() is not None:
                self.listbox9.addItem("Ürün: " + self.listbox1.currentItem().text())
          if self.listbox2.currentItem() is not None:
              self.listbox9.addItem("İçecek: " + self.listbox2.currentItem().text())
          if self.listbox3.currentItem() is not None:
              self.listbox9.addItem("1.Ürün Adet: " + self.listbox3.currentItem().text())
          if self.listbox4.currentItem() is not None:
              self.listbox9.addItem("2.Ürün Adet: " + self.listbox4.currentItem().text())
          if self.listbox5.currentItem() is not None:
              self.listbox9.addItem("3.Ürün Adet: " + self.listbox5.currentItem().text())
          if self.listbox6.currentItem() is not None:
              self.listbox9.addItem("1.İçecek Adet: " + self.listbox6.currentItem().text())
          if self.listbox7.currentItem() is not None:
              self.listbox9.addItem("2.İçecek Adet: " + self.listbox7.currentItem().text())
          if self.listbox8.currentItem() is not None:
              self.listbox9.addItem("3.İçecek Adet: " + self.listbox8.currentItem().text())
        

    def temizle(self):
        self.listbox1.clearSelection()
        self.listbox2.clearSelection()
        self.listbox3.clearSelection()
        self.listbox4.clearSelection()
        self.listbox5.clearSelection()
        self.listbox6.clearSelection()
        self.listbox7.clearSelection()
        self.listbox8.clearSelection()
        self.listbox9.clear()
    
    def hesapla(self):
        if self.hata() == -1: return

        self.listbox9.clear()
        toplam = 0
        if self.listbox1.currentRow() == 0:
            toplam += 50 * int(self.listbox3.currentItem().text())
        elif self.listbox1.currentRow() == 1:
            toplam += 100 * int(self.listbox3.currentItem().text())
        elif self.listbox1.currentRow() == 2:
            toplam += 150 * int(self.listbox3.currentItem().text())
        if self.listbox2.currentRow() == 0:
            toplam += 30 * int(self.listbox6.currentItem().text())
        elif self.listbox2.currentRow() == 1:
            toplam += 20 * int(self.listbox6.currentItem().text())
        elif self.listbox2.currentRow() == 2:
            toplam += 10 * int(self.listbox6.currentItem().text())
        self.listbox9.addItem("Toplam Tutar: " + str(toplam) + "TL")

        self.yaz()

    def hata(self):
        if not self.listbox1.selectedIndexes():
            QMessageBox.warning(self,"Hata","Lütfen Ürün Seçiniz")
            return -1

        if not self.listbox3.selectedIndexes():
            QMessageBox.warning(self,"Hata","Lütfen Ürün Adet Seçiniz")
            return -1
        
        if self.listbox2.selectedIndexes() and not self.listbox6.selectedIndexes():
            QMessageBox.warning(self,"Hata","Lütfen İçecek Adet Seçiniz")
            return -1

        return 0

if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = Window()
    window.show()
    sys.exit(app.exec())