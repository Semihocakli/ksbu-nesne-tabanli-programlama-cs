from PyQt6.QtCore import *
from PyQt6.QtGui import *
from PyQt6.QtWidgets import *
from PyQt6 import uic

import sys

class Window(QWidget):
    def __init__(self):
        super().__init__()

        self.setGeometry(100, 100, 450, 350)
        self.setWindowTitle("Vize Final Hesaplama")
        self.Widgets()

    def Widgets(self):
        # Vize,final,büt Label
        self.vize_final_hesaplama = QLabel("Vize Final Hesaplama", self)
        self.vize_final_hesaplama.move(100, 20)
        self.label_vize = QLabel("Vize:", self)
        self.label_vize.move(50, 50)
        self.label_final = QLabel("Final:", self)
        self.label_final.move(50, 100)
        self.label_but = QLabel("Büt:", self)
        self.label_but.move(50, 150)

        # hesaplama labellari
        self.label_ort_ = QLabel("...........", self)
        self.label_ort_.move(350, 50)
        self.label_durum1_ = QLabel(".................:", self)
        self.label_durum1_.move(350, 100)
        self.label_durum2_ = QLabel("...........:", self)
        self.label_durum2_.move(350, 150)
        self.label_harf_ = QLabel("...........:", self)
        self.label_harf_.move(350, 200)

        # ort. , durum1 , durum 2 , harf label
        self.label_ort = QLabel("Ortalama:", self)
        self.label_ort.move(250, 50)
        self.label_durum1 = QLabel("Durum:", self)
        self.label_durum1.move(250, 100)
        self.label_durum2 = QLabel("Durum2", self)
        self.label_durum2.move(250, 150)
        self.label_harf = QLabel("Harf:", self)
        self.label_harf.move(250, 200)

        # Vize,final,büt textbox
        self.textbox_vize = QLineEdit(self)
        self.textbox_vize.move(100, 50)
        self.textbox_vize.installEventFilter(self)
        self.textbox_final = QLineEdit(self)
        self.textbox_final.move(100, 100)
        self.textbox_final.installEventFilter(self)
        self.textbox_but = QLineEdit(self)
        self.textbox_but.move(100, 150)
        self.textbox_but.setEnabled(False)

        # hesapla button1 
        self.button1 = QPushButton("Not Hesapla1", self)
        self.button1.move(100, 200)
        self.button1.clicked.connect(self.hesapla)
        self.button1.clicked.connect(self.gecti_kaldi)

        # temizle button2
        self.button2 = QPushButton("Temizle", self)
        self.button2.move(100, 280)
        self.button2.clicked.connect(self.temizle)

        # büt hesapla button3
        self.button3 = QPushButton("Büt Hesapla", self)
        self.button3.move(100, 240)
        self.button3.setEnabled(False)
        # self.button3.clicked.connect(self.büt_hesapla)

        # kapat button4
        self.button4 = QPushButton("Kapat", self)
        self.button4.move(300, 280)
        self.button4.clicked.connect(self.close)
        
    def eventFilter(self, obj, event):
        if obj == self.textbox_vize:
            if event.type() == QEvent.Type.MouseButtonRelease:
                self.textbox_vize.setStyleSheet("QLineEdit { background-color: yellow; }")
                self.textbox_final.setStyleSheet("QLineEdit { background-color: white; }")
        elif obj == self.textbox_final:
            if event.type() == QEvent.Type.MouseButtonRelease:
                self.textbox_final.setStyleSheet("QLineEdit { background-color: yellow; }")
                self.textbox_vize.setStyleSheet("QLineEdit { background-color: white; }")

        return super().eventFilter(obj, event)
       
    def hesapla(self):
        try:
            vize = float(self.textbox_vize.text())
            final = float(self.textbox_final.text())
            
            if not(0 <= vize <= 100) or not(0 <= final <= 100):
                m_box = QMessageBox.information(self, "Hata", "Geçerli not aralığında değerler giriniz (0-100):")
                return m_box

            ort = vize * 0.4 + final * 0.6
            self.label_ort_.setText(str(ort))

            if self.textbox_vize.text() == "" or self.textbox_final.text() == "":
                m_box = QMessageBox.information(self, "Not", "Lütfen notu giriniz:")
                return m_box
        except ValueError:
            m_box = QMessageBox.information(self, "Hata", "Geçerli sayısal değerler giriniz:")
            return m_box
    
    def gecti_kaldi(self):
            vize = float(self.textbox_vize.text())
            final = float(self.textbox_final.text())

            
            if not(0 <= vize <= 100) or not(0 <= final <= 100):
                m_box = QMessageBox.information(self, "Hata", "Geçerli not aralığında değerler giriniz (0-100):")
                self.textbox_vize.clear()
                self.textbox_final.clear()
                return m_box
            
            ort = vize * 0.4 + final * 0.6

            if ort >= 60:
                self.label_durum2_.setText("GECTİ")
            if 100 >= ort >= 90:
                self.label_harf_.setText("AA")
            if 90 >= ort >= 80:
                self.label_harf_.setText("BB")
            if 80 >= ort >= 70:
                self.label_harf_.setText("CC")
            if 70 >= ort >= 60:
                self.label_harf_.setText("DD")
            else:
                self.label_durum2_.setText("KALDI")
                self.label_durum2_.setStyleSheet("QLabel { background-color: red; color: white; }")
                self.label_harf_.setText("FF")
                self.label_harf_.setStyleSheet("QLabel { background-color: purple; color: white; }")
                self.label_durum1_.setText("Büt girin")
                self.textbox_vize.setEnabled(False)
                self.textbox_final.setEnabled(False)
                self.button1.setEnabled(False)
                self.textbox_but.setEnabled(True)
                self.button3.setEnabled(True)
                self.button3.clicked.connect(self.gecti_kaldi)

                if self.textbox_but.text() != '':
                    vize = float(self.textbox_vize.text())
                    büt = float(self.textbox_but.text())
                    yeni_ort = vize * 0.4 + büt * 0.6

                    if yeni_ort >= 60:
                        self.label_ort_.setText(str(yeni_ort))
                        self.label_durum2_.setText("GECTİ")
                        self.label_durum2_.setStyleSheet("QLabel { background-color: green; color: white; }")
                        self.label_durum1_.setText("")
                    if 100 >= yeni_ort >= 90:
                        self.label_harf_.setText("AA")
                    if 90 >= yeni_ort >= 80:
                        self.label_harf_.setText("BB")
                    if 80 >= yeni_ort >= 70:
                        self.label_harf_.setText("CC")
                    if 70 >= yeni_ort >= 60:
                        self.label_harf_.setText("DD")
                    else:
                        self.textbox_vize.setEnabled(False)
                        self.textbox_final.setEnabled(False)
                        self.button1.setEnabled(False)
                        self.button3.setEnabled(False)
                        self.textbox_but.setEnabled(False)
                        self.textbox_final.setEnabled(False)

    def temizle(self):
    
        self.textbox_vize.clear()
        self.textbox_final.clear()
        self.textbox_but.clear()

        self.label_ort_.clear()
        self.label_durum1_.clear()
        self.label_durum2_.clear()
        self.label_harf_.clear()

        self.textbox_vize.setStyleSheet("QLineEdit { background-color: white; }")
        self.textbox_final.setStyleSheet("QLineEdit { background-color: white; }")
        self.label_durum2_.setStyleSheet("")  
        self.label_harf_.setStyleSheet("")  


        self.textbox_vize.setEnabled(True)
        self.textbox_final.setEnabled(True)
        self.button1.setEnabled(True)
        self.textbox_but.setEnabled(False)
        self.button3.setEnabled(False)

    # def büt_hesapla(self):
    #     vize = float(self.textbox_vize.text())
    #     büt = float(self.textbox_but.text())
    #     yeni_ort = vize * 0.4 + büt * 0.6

    #     if yeni_ort >= 60:
    #         self.label_ort_.setText(str(yeni_ort))
    #         self.label_durum2_.setText("GECTİ")
    #         self.label_durum1_.setText("")
    #     else:
    #         self.textbox_vize.setEnabled(False)
    #         self.textbox_final.setEnabled(False)
    #         self.button1.setEnabled(False)
    #         self.button3.setEnabled(False)
    #         self.textbox_but.setEnabled(False)
    #         self.textbox_final.setEnabled(False)

if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = Window()
    window.show()
    sys.exit(app.exec())
