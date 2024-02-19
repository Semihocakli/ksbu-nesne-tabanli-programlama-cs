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

        self.setGeometry(100, 100, 400, 350)
        self.setWindowTitle("listbox2_ders")
        self.Widgets()

    def Widgets(self):
        # labellar
        self.label1 = QLabel("indeks sırası",self)
        self.label1.move(280,200)
        self.label2 = QLabel("isim",self)
        self.label2.move(280,230)
        self.label3 = QLabel("liste sırası",self)
        self.label3.move(280,260)
        self.label4 = QLabel("Arkadaş giriniz:",self)
        self.label4.move(40,30)
        # listbox
        self.listbox = QListWidget(self)
        self.listbox.move(280,40)
        self.listbox.resize(100,150)
        self.listbox.addItem("AHMET")
        self.listbox.addItem("YAVUZ")
        self.listbox.addItem("OSMAN")
        self.listbox.addItem("FATMA")
        self.listbox.itemClicked.connect(self.listbox_click)
        # radiobuttonlar
        self.radioButton1 = QRadioButton("BAŞA EKLE/SİL",self)
        self.radioButton2 = QRadioButton("SEÇİLİ(VARSAYILAN)EKLE/SİL",self)
        self.radioButton3 = QRadioButton("SEÇİLİ(ALTA) EKLE/SİL",self)
        self.radioButton4 = QRadioButton("SONA EKLE/SİL",self)
        # textbox
        self.textbox1 = QLineEdit(self)
        self.textbox1.move(40,50)
        # groupbox
        self.groupbox = QGroupBox(self)
        self.groupbox.move(40,150)
        self.groupbox.resize(200,150)
        self.groupbox_layout = QVBoxLayout(self.groupbox)
        self.groupbox_layout.addWidget(self.radioButton1)
        self.groupbox_layout.addWidget(self.radioButton2)
        self.groupbox_layout.addWidget(self.radioButton3)
        self.groupbox_layout.addWidget(self.radioButton4)
        #butonlar 
        self.button1 = QPushButton("Arkadaş Ekleyin",self)
        self.button1.move(40,80)
        self.button1.clicked.connect(self.button1_click)

        self.button2 = QPushButton("Arkadaş Silin",self)
        self.button2.move(40,110)
        self.button2.clicked.connect(self.button2_click)
        
    def button1_click(self):
        if self.textbox1.text() == "":
            return

        if self.radioButton1.isChecked():
            self.listbox.insertItem(0, self.textbox1.text())
        elif self.radioButton2.isChecked():
            current_row = self.listbox.currentRow()
            if current_row != -1:
                self.listbox.insertItem(current_row, self.textbox1.text())
            else:
                self.listbox.addItem(self.textbox1.text())
        elif self.radioButton3.isChecked():
            current_row = self.listbox.currentRow()
            if current_row != -1:
                self.listbox.insertItem(current_row + 1, self.textbox1.text())
            else:
                self.listbox.addItem(self.textbox1.text())
        elif self.radioButton4.isChecked():
            self.listbox.addItem(self.textbox1.text())
    
    def button2_click(self):
        current_row = self.listbox.currentRow()
        if current_row != -1:
            self.listbox.takeItem(current_row)
        else:
            self.listbox.takeItem(self.listbox.count() - 1)

    def listbox_click(self, item): 
        current_row = self.listbox.row(item)
        self.label1.setText(f"İndeks Sırası: {current_row}")
        self.label2.setText(f"İsim: {item.text()}")
        self.label3.setText(f"Liste Sırası: {current_row + 1}")


if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = Window()
    window.show()
    sys.exit(app.exec())