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

        self.setGeometry(100, 100, 650, 400)
        self.setWindowTitle("Listbox1_tekli")
        self.Widgets()

    def Widgets(self):
        # textbox
        self.textBox1 = QLineEdit(self)
        self.textBox1.move(200, 300)
        self.textBox1.resize(120, 20)
        # butonlar
        self.buton1 = QPushButton("Ekle",self)
        self.buton1.move(50,50)
        self.buton1.resize(120,20)
        self.buton1.clicked.connect(self.ekle)
        self.buton2 = QPushButton("degistir",self)
        self.buton2.move(50,80)
        self.buton2.resize(120,20)
        self.buton2.clicked.connect(self.degistir)
        self.buton3 = QPushButton("araya ekle(seçili üstü)",self)
        self.buton3.move(50,110)
        self.buton3.resize(120,20)
        self.buton3.clicked.connect(self.arayaekle)
        self.buton4 = QPushButton("araya ekle(en üste)",self)
        self.buton4.move(50,140)
        self.buton4.resize(120,20)
        self.buton4.clicked.connect(self.arayaekle2)
        self.buton5 = QPushButton("araya ekle(en alta)",self)
        self.buton5.move(50,170)
        self.buton5.resize(120,20)
        self.buton5.clicked.connect(self.arayaekle3)
        self.buton6 = QPushButton("sil",self)
        self.buton6.move(50,200)
        self.buton6.resize(120,20)
        self.buton6.clicked.connect(self.sil)
        self.buton7 = QPushButton("temizle",self)
        self.buton7.move(50,230)
        self.buton7.resize(120,20)
        self.buton7.clicked.connect(self.temizle)
        self.buton8 = QPushButton("kapat",self)
        self.buton8.move(50,260)
        self.buton8.resize(120,20)
        self.buton8.clicked.connect(self.Kapat)

        # listbox
        self.listbox = QListWidget(self)
        self.listbox.move(200,50)
        self.listbox.resize(100,240)
        self.listbox.addItems(["KUTAHYA1", "KUTAHYA2", "KUTAHYA3", "KUTAHYA4", "KUTAHYA5"])


        # butonlar
        self.buton9 = QPushButton("kopyala (üstte)>>",self)
        self.buton9.move(350,50)
        self.buton9.resize(120,20)
        self.buton9.clicked.connect(self.kopyala_ustte)
        self.buton10 = QPushButton("kopyala (altta)>>",self)
        self.buton10.move(350,80)
        self.buton10.resize(120,20)
        self.buton10.clicked.connect(self.kopyala_altta)
        self.buton11 = QPushButton("kopyala (seçili)>>",self)
        self.buton11.move(350,110)
        self.buton11.resize(120,20)
        self.buton11.clicked.connect(self.kopyala_secili)
        self.buton12 = QPushButton("taşı (üstte)>>",self)
        self.buton12.move(350,140)
        self.buton12.resize(120,20)
        self.buton12.clicked.connect(self.tasi_ustte)
        self.buton13 = QPushButton("taşı (altta)>>",self)
        self.buton13.move(350,170)
        self.buton13.resize(120,20)
        self.buton13.clicked.connect(self.tasi_altta)
        self.buton14 = QPushButton("taşı (seçili)>>",self)
        self.buton14.move(350,200)
        self.buton14.resize(120,20)
        self.buton14.clicked.connect(self.kopyala_secili_ters)
        self.buton15 = QPushButton("<<kopyala(seçili)",self)
        self.buton15.move(350,230)
        self.buton15.resize(120,20)
        self.buton15.clicked.connect(self.tasi_secili_ters)
        self.buton16 = QPushButton("<<taşı(seçili)",self)
        self.buton16.move(350,260)
        self.buton16.resize(120,20)
        self.buton16.clicked.connect(self.tasi4)
        self.buton17 = QPushButton("<<Yer değiştir>>",self)
        self.buton17.move(350,290)
        self.buton17.resize(120,20)
        self.buton17.clicked.connect(self.yerdegistir)

        # listbox
        self.listbox2 = QListWidget(self)
        self.listbox2.move(500,50)
        self.listbox2.resize(100,240)
        self.listbox2.addItems(["ANKARA1", "ANKARA2", "ANKARA3",])
        
    def ekle(self):
        # C# code for button1_Click
        flag = self.textBox1.text() == ""
        if flag:
            QMessageBox.warning(self, "Warning", "TB1 giriniz")
            self.textBox1.setFocus()
        else:
            self.listbox1.addItem(self.textBox1.text())
            self.textBox1.clear()
            self.adet1()

    def degistir(self):
        # C# code for button2_Click
        flag = self.textBox1.text() == "" or self.listbox1.currentRow() == -1
        if flag:
            QMessageBox.warning(self, "Warning", "TB1 giriniz/LB1 Seçim Yapınız")
            self.textBox1.setFocus()
        else:
            self.listbox1.currentItem().setText(self.textBox1.text())
            self.textBox1.clear()
            self.adet1()

    def arayaekle(self):
        # C# code for button3_Click
        flag = self.textBox1.text() == "" or self.listbox1.currentRow() == -1
        if flag:
            QMessageBox.warning(self, "Warning", "TB1 giriniz/LB1 Seçim Yapınız")
            self.textBox1.setFocus()
        else:
            self.listbox1.insertItem(self.listbox1.currentRow(), self.textBox1.text())
            self.adet1()

    def arayaekle2(self):
        # C# code for button4_Click
        flag = self.textBox1.text() == "" or self.listbox1.currentRow() == -1
        if flag:
            QMessageBox.warning(self, "Warning", "TB1 giriniz/LB1 Seçim Yapınız")
            self.textBox1.setFocus()
        else:
            self.listbox1.insertItem(self.listbox1.currentRow() + 1, self.textBox1.text())
            self.adet1()

    def arayaekle3(self):
        # C# code for button5_Click
        flag = self.textBox1.text() == ""
        if flag:
            QMessageBox.warning(self, "Warning", "TB1 giriniz")
            self.textBox1.setFocus()
        else:
            self.listbox1.insertItem(0, self.textBox1.text())
            self.adet1()

    def arayaekle4(self):
        # C# code for button6_Click
        flag = self.textBox1.text() == ""
        if flag:
            QMessageBox.warning(self, "Warning", "TB1 giriniz")
            self.textBox1.setFocus()
        else:
            self.listbox1.insertItem(self.listbox1.count(), self.textBox1.text())
            self.adet1()

    def sil(self):
        # C# code for button7_Click
        flag = len(self.listbox1.selectedIndexes()) == 0
        if flag:
            QMessageBox.warning(self, "Warning", "LB1 Seçim yapınız...")
            self.textBox1.setFocus()
        else:
            self.listbox1.takeItem(self.listbox1.currentRow())
            self.adet1()

    def kopyala_ustte(self):
        # C# code for button11_Click
        flag = len(self.listbox1.selectedIndexes()) == 0
        if flag:
            QMessageBox.warning(self, "Warning", "LB1 Seçim yapınız...")
            self.textBox1.setFocus()
        else:
            self.listbox2.insertItem(0, self.listbox1.currentItem().text())
            self.adet1()

    def kopyala_altta(self):
        # C# code for button12_Click
        flag = len(self.listbox1.selectedIndexes()) == 0
        if flag:
            QMessageBox.warning(self, "Warning", "LB1 Seçim yapınız...")
            self.textBox1.setFocus()
        else:
            self.listbox2.addItem(self.listbox1.currentItem().text())
            self.adet1()

    def kopyala_secili(self):
        # C# code for button13_Click
        flag = len(self.listbox1.selectedIndexes()) == 0 or len(self.listbox2.selectedIndexes()) == 0
        if flag:
            QMessageBox.warning(self, "Warning", "LB1/LB2 Seçim yapınız...")
            self.textBox1.setFocus()
        else:
            self.listbox2.insertItem(self.listbox2.currentRow(), self.listbox1.currentItem().text())
            self.adet1()

    def tasi_ustte(self):
        # C# code for button14_Click
        flag = len(self.listbox1.selectedIndexes()) == 0
        if flag:
            QMessageBox.warning(self, "Warning", "LB1 Seçim yapınız...")
            self.textBox1.setFocus()
        else:
            self.listbox2.insertItem(0, self.listbox1.currentItem().text())
            self.listbox1.takeItem(self.listbox1.currentRow())
            self.adet1()

    def tasi_altta(self):
        # C# code for button15_Click
        flag = len(self.listbox1.selectedIndexes()) == 0
        if flag:
            QMessageBox.warning(self, "Warning", "LB1 Seçim yapınız...")
            self.textBox1.setFocus()
        else:
            self.listbox2.addItem(self.listbox1.currentItem().text())
            self.listbox1.takeItem(self.listbox1.currentRow())
            self.adet1()

    def tasi_secili(self):
        # C# code for button16_Click
        flag = len(self.listbox1.selectedIndexes()) == 0 or len(self.listbox2.selectedIndexes()) == 0
        if flag:
            QMessageBox.warning(self, "Warning", "LB1/LB2 Seçim yapınız...")
            self.textBox1.setFocus()
        else:
            self.listbox2.insertItem(self.listbox2.currentRow(), self.listbox1.currentItem().text())
            self.listbox1.takeItem(self.listbox1.currentRow())
            self.adet1()

    def kopyala_secili_ters(self):
        # C# code for button9_Click
        flag = len(self.listbox1.selectedIndexes()) == 0 or len(self.listbox2.selectedIndexes()) == 0
        if flag:
            QMessageBox.warning(self, "Warning", "LB1/LB2 Seçim yapınız...")
            self.textBox1.setFocus()
        else:
            self.listbox1.insertItem(self.listbox1.currentRow(), self.listbox2.currentItem().text())
            self.adet1()

    def tasi_secili_ters(self):
        # C# code for button10_Click
        flag = len(self.listbox1.selectedIndexes()) == 0 or len(self.listbox2.selectedIndexes()) == 0
        if flag:
            QMessageBox.warning(self, "Warning", "LB1/LB2 Seçim yapınız...")
            self.textBox1.setFocus()
        else:
            self.listbox1.insertItem(self.listbox1.currentRow(), self.listbox2.currentItem().text())
            self.listbox2.takeItem(self.listbox2.currentRow())
            self.adet1()

    def tasi4(self):
        # Implement the functionality for button16_Click
        flag = len(self.listbox1.selectedIndexes()) == 0
        if flag:
            QMessageBox.warning(self, "Warning", "LB1 Seçim yapınız...")
            self.textBox1.setFocus()
        else:
            selected_item = self.listbox1.currentItem()
            current_row = self.listbox1.currentRow()

            if current_row > 0:
                self.listbox1.takeItem(current_row)
                self.listbox1.insertItem(current_row - 1, selected_item.text())
                self.listbox1.setCurrentRow(current_row - 1)
                self.adet1()

    def yerdegistir(self):
        # Implement the functionality for button17_Click
        flag = len(self.listbox1.selectedIndexes()) == 0 or len(self.listbox2.selectedIndexes()) == 0
        if flag:
            QMessageBox.warning(self, "Warning", "LB1/LB2 Seçim yapınız...")
            self.textBox1.setFocus()
        else:
            item1 = self.listbox1.currentItem().text()
            item2 = self.listbox2.currentItem().text()

            self.listbox1.currentItem().setText(item2)
            self.listbox2.currentItem().setText(item1)
            self.adet1()

    def temizle(self):
        # C# code for button7_Click
        self.listbox1.clear()
        self.listbox2.clear()
        self.adet1()

    def Kapat(self):
        # C# code for button8_Click
        self.close()


if __name__ == '__main__':
    app = QApplication(sys.argv)
    window = Window()
    window.show()
    sys.exit(app.exec())