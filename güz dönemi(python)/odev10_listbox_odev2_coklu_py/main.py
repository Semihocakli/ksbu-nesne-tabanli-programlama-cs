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

        self.setGeometry(100, 100, 680, 400)
        self.setWindowTitle("Listbox Ödev 2")
        self.Widgets()

    def Widgets(self):
        self.label1 = QLabel("Toplam Eleman (LB1): 0", self)
        self.label1.move(200, 330)

        self.label2 = QLabel("Toplam Eleman (LB2): 0", self)
        self.label2.move(500, 330)

        self.label3 = QLabel("Seçili Eleman: 0", self)
        self.label3.move(30, 350)

        self.label4 = QLabel("Son Eklenen: ", self)
        self.label4.move(200, 350)

        self.label5 = QLabel("Seçili Toplam: 0", self)
        self.label5.move(350, 350)
        self.textBox1 = QLineEdit(self)
        self.textBox1.move(30, 20)
        self.textBox1.resize(120, 20)

        self.button = QPushButton("Ekle", self)
        self.button.move(30, 50)
        self.button.resize(120, 20)
        self.button.clicked.connect(self.ekle_butonu)

        self.button2 = QPushButton("Degistir", self)
        self.button2.move(30, 80)
        self.button2.resize(120, 20)
        self.button2.clicked.connect(self.degistir_butonu)

        self.button3 = QPushButton("Secili Yer Degistir", self)
        self.button3.move(30, 240)
        self.button3.resize(120, 20)
        self.button3.clicked.connect(self.yerdegistir_butonu)

        self.button4 = QPushButton("Secili Sil", self)
        self.button4.move(30, 280)
        self.button4.resize(120, 20)
        self.button4.clicked.connect(self.sil_butonu)

        self.button5 = QPushButton("Temizle", self)
        self.button5.move(30, 320)
        self.button5.resize(120, 20)
        self.button5.clicked.connect(self.temizle_butonu)

        self.listbox1 = QListWidget(self)
        self.listbox1.move(200, 20)
        self.listbox1.resize(120, 300)
        self.listbox1.itemSelectionChanged.connect(self.listbox1_secim_degisti)
        self.listbox1.setSelectionMode(QAbstractItemView.SelectionMode.MultiSelection)
        self.listbox1.addItems(["KUTAHYA1", "KUTAHYA2", "KUTAHYA3", "KUTAHYA4", "KUTAHYA5"])

        self.button6 = QPushButton("Kopyala (üstte)>>", self)
        self.button6.move(350, 50)
        self.button6.resize(120, 20)
        self.button6.clicked.connect(self.kopyala_butonu_alta)

        self.button7 = QPushButton("Kopyala (altta)>>", self)
        self.button7.move(350, 80)
        self.button7.resize(120, 20)
        self.button7.clicked.connect(self.kopyala_butonu_secili)

        self.button8 = QPushButton("Kopyala (secili1)>>", self)
        self.button8.move(350, 110)
        self.button8.resize(120, 20)
        self.button8.clicked.connect(self.kopyala_butonu1)

        self.button9 = QPushButton("Kopyala (secili2)>>", self)
        self.button9.move(350, 140)
        self.button9.resize(120, 20)
        self.button9.clicked.connect(self.kopyala_butonu2)

        self.button10 = QPushButton("taşı üstte)>>", self)
        self.button10.move(350, 170)
        self.button10.resize(120, 20)
        self.button10.clicked.connect(self.tasi_butonu1)

        self.button11 = QPushButton("taşı üstte2)>>", self)
        self.button11.move(350, 200)
        self.button11.resize(120, 20)
        self.button11.clicked.connect(self.tasi_butonu2)

        self.button12 = QPushButton("taşı üstte3)>>", self)
        self.button12.move(350, 230)
        self.button12.resize(120, 20)
        self.button12.clicked.connect(self.tasi_butonu3)

        self.button13 = QPushButton("taşı altta)>>", self)
        self.button13.move(350, 260)
        self.button13.resize(120, 20)
        self.button13.clicked.connect(self.altatasi_butonu)

        self.button14 = QPushButton("taşı secili)>>", self)
        self.button14.move(350, 290)
        self.button14.resize(120, 20)
        self.button14.clicked.connect(self.secilitasi_butonu)

        self.button15 = QPushButton("kapat", self)
        self.button15.move(350, 320)
        self.button15.resize(120, 20)
        self.button15.clicked.connect(self.close)

        self.listbox2 = QListWidget(self)
        self.listbox2.move(500, 20)
        self.listbox2.resize(120, 300)
        self.listbox2.addItems(["BURSA1", "BURSA2", "BURSA3"])

    def secilitasi_butonu(self):
        selected_count = len(self.listbox1.selectedItems())
        if selected_count < 2:
            QMessageBox.warning(self, "Uyarı", "LB1 en az 2 seçiniz")
            self.textBox1.setFocus()
        else:
            for i in range(selected_count):
                self.listbox2.insertItem(self.listbox2.currentRow(), self.listbox1.selectedItems()[i].text())
            for j in range(selected_count - 1, -1, -1):
                self.listbox1.takeItem(self.listbox1.row(self.listbox1.selectedItems()[j]))
            self.adet1()

    def altatasi_butonu(self):
        selected_count = len(self.listbox1.selectedItems())
        if selected_count < 2:
            QMessageBox.warning(self, "Uyarı", "LB1 en az 2 seçiniz")
            self.textBox1.setFocus()
        else:
            for i in range(selected_count):
                self.listbox2.insertItem(self.listbox2.count(), self.listbox1.selectedItems()[i].text())
            for j in range(selected_count - 1, -1, -1):
                self.listbox1.takeItem(self.listbox1.row(self.listbox1.selectedItems()[j]))
            self.adet1()

    def tasi_butonu1(self):
        selected_count = len(self.listbox1.selectedItems())
        if selected_count < 2:
            QMessageBox.warning(self, "Uyarı", "LB1 en az 2 seçiniz")
            self.textBox1.setFocus()
        else:
            for i in range(selected_count):
                self.listbox2.insertItem(i, self.listbox1.selectedItems()[0].text())
                self.listbox1.takeItem(self.listbox1.row(self.listbox1.selectedItems()[0]))
            self.adet1()

    def tasi_butonu2(self):
        selected_count = len(self.listbox1.selectedItems())
        if selected_count < 2:
            QMessageBox.warning(self, "Uyarı", "LB1 en az 2 seçiniz")
            self.textBox1.setFocus()
        else:
            for i in range(selected_count):
                if i < self.listbox1.count():
                    item_text = self.listbox1.selectedItems()[i].text()
                    self.listbox2.insertItem(i, item_text)
                    self.listbox1.takeItem(self.listbox1.row(self.listbox1.selectedItems()[i]))
            self.adet1()

    def tasi_butonu3(self):
        selected_count = len(self.listbox1.selectedItems())
        if selected_count < 2:
            QMessageBox.warning(self, "Uyarı", "LB1 en az 2 seçiniz")
            self.textBox1.setFocus()
        else:
            for i in range(selected_count):
                self.listbox2.insertItem(i, self.listbox1.selectedItems()[i].text())
            for j in range(selected_count - 1, -1, -1):
                self.listbox1.takeItem(self.listbox1.row(self.listbox1.selectedItems()[j]))
            self.adet1()

    def kopyala_butonu1(self):
        selected_count = len(self.listbox1.selectedItems())
        selected_index2 = self.listbox2.currentRow()

        if selected_count < 2 or selected_index2 == -1:
            QMessageBox.warning(self, "Uyarı", "LB1 en az 2 seçiniz / LB2 Seçiniz")
            self.textBox1.setFocus()
        else:
            for i in range(selected_count):
                self.listbox2.insertItem(selected_index2, self.listbox1.selectedItems()[i].text())
            self.adet1()

    def kopyala_butonu2(self):
        selected_count = len(self.listbox1.selectedItems())
        if selected_count < 2:
            QMessageBox.warning(self, "Uyarı", "LB1 en az 2 seçiniz")
            self.textBox1.setFocus()
        else:
            for i in range(self.listbox1.count()):
                if self.listbox1.item(i).isSelected():
                    self.listbox2.insertItem(self.listbox2.currentRow(), self.listbox1.item(i).text())
            self.adet1()
            self.textBox1.setFocus()

    def kopyala_butonu_secili(self):
        selected_count = len(self.listbox1.selectedItems())
        selectedIndex2 = self.listbox2.currentRow()
        if selected_count < 2 or selectedIndex2 == -1:
            QMessageBox.warning(self, "Uyarı", "LB1 en az 2 seçiniz / LB2 seçiniz")
            self.textBox1.setFocus()
        else:
            for i in range(selected_count):
                self.listbox2.insertItem(selectedIndex2, self.listbox1.selectedItems()[i].text())
            self.adet1()

    def kopyala_butonu_alta(self):
        selected_count = len(self.listbox1.selectedItems())
        if selected_count < 2:
            QMessageBox.warning(self, "Uyarı", "LB1 en az 2 seçiniz")
            self.textBox1.setFocus()
        else:
            for i in range(selected_count):
                self.listbox2.insertItem(self.listbox2.count(), self.listbox1.selectedItems()[i].text())
            self.adet1()

    def ekle_butonu(self):
        if not self.textBox1.text():
            QMessageBox.warning(self, "Uyarı", "TB1 giriniz")
            self.textBox1.setFocus()
        else:
            self.listbox1.addItem(self.textBox1.text())
            self.textBox1.clear()
            self.adet1()

    def adet1(self):
        self.label1.setText(str(self.listbox1.count()))
        self.label3.setText(str(self.listbox2.count()))
        self.label5.setText(str(len(self.listbox1.selectedItems())))
        self.textBox1.setFocus()

    def degistir_butonu(self):
        selected_index = self.listbox1.currentRow()
        if self.textBox1.text() == "" or selected_index == -1:
            QMessageBox.warning(self, "Uyarı", "TB1 giriniz / LB1 Seçim Yapınız")
            self.textBox1.setFocus()
        else:
            self.listbox1.item(selected_index).setText(self.textBox1.text())
            self.textBox1.clear()
            self.adet1()

    def yerdegistir_butonu(self):
        selected_indices = self.listbox1.selectedIndexes()
        if len(selected_indices) != 2:
            QMessageBox.warning(self, "Uyarı", "LB1'den 2 tane seçiniz")
            self.textBox1.setFocus()
        else:
            index, index2 = selected_indices[0].row(), selected_indices[1].row()
            value, value2 = self.listbox1.item(index).text(), self.listbox1.item(index2).text()
            self.listbox1.item(index).setText(value2)
            self.listbox1.item(index2).setText(value)
            self.adet1()

    def sil_butonu(self):
        selected_indices = self.listbox1.selectedIndexes()
        if not selected_indices:
            QMessageBox.warning(self, "Uyarı", "LB1 Seçim yapınız")
            self.textBox1.setFocus()
        else:
            selected_index = selected_indices[0].row()
            self.listbox1.takeItem(selected_index)
            self.adet1()

    def temizle_butonu(self):
        self.listbox1.clear()
        self.adet1()

    def listbox1_secim_degisti(self):
        selected_items = self.listbox1.selectedItems()
        selected_count = len(selected_items)

        # Seçili eleman sayısını ve değerlerini gösteren etiketi güncelle
        self.label3.setText(f"Seçili Eleman: {selected_count}")

        if selected_count > 0:
            # Eğer en az bir eleman seçiliyse, son eklenen etiketi güncelle
            last_selected_item = selected_items[-1]
            self.label4.setText(f"Son Eklenen: {last_selected_item.text()}")

        # Seçili toplam etiketini güncelle
        self.label5.setText(f"Seçili Toplam: {len(self.listbox1.selectedItems())}")

if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = Window()
    window.show()
    sys.exit(app.exec())
