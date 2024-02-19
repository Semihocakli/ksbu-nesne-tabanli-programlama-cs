from PyQt6.QtCore import *
from PyQt6.QtGui import *
from PyQt6.QtWidgets import *
from PyQt6 import uic

import sys


class MainWindow(QWidget):
    def __init__(self) -> None:
        super().__init__()
        uic.loadUi("main.ui", self)

        self.default_palette = self.label_digit.palette()

        self.lineEdit_input.focusInEvent = self.focusInEvent
        self.lineEdit_input.setStyleSheet(
            "QLineEdit { background-color: white; }")
        self.lineEdit_input.installEventFilter(self)
        self.lineEdit_input.setFocus()

        self.button1.clicked.connect(self.button1_clicked)
        self.button2.clicked.connect(self.button2_clicked)
        self.button3.clicked.connect(self.button3_clicked)
        self.button4.clicked.connect(self.button4_clicked)
        self.button5.clicked.connect(self.button5_clicked)
        self.button6.clicked.connect(self.button6_clicked)
        self.button7.clicked.connect(self.button7_clicked)
        self.button8.clicked.connect(self.button8_clicked)
        self.button9.clicked.connect(self.button9_clicked)
        self.button0.clicked.connect(self.button0_clicked)

        self.button_add.clicked.connect(self.button_add_clicked)
        self.button_sub.clicked.connect(self.button_sub_clicked)
        self.button_mul.clicked.connect(self.button_mul_clicked)
        self.button_div.clicked.connect(self.button_div_clicked)

        self.button_equal.clicked.connect(self.equal_clicked)
        self.button_close.clicked.connect(self.close)
        self.button_c.clicked.connect(self.clear_clicked)

    def eventFilter(self, obj, event):
        if obj == self.lineEdit_input:
            if event.type() == QEvent.Type.FocusIn:
                self.lineEdit_input.setStyleSheet(
                    "QLineEdit { background-color: yellow; }")
            elif event.type() == QEvent.Type.FocusOut:
                self.lineEdit_input.setStyleSheet(
                    "QLineEdit { background-color: white; }")
        return super().eventFilter(obj, event)

    def button1_clicked(self):
        self.lineEdit_input.setText(self.lineEdit_input.text() + "1")

    def button2_clicked(self):
        self.lineEdit_input.setText(self.lineEdit_input.text() + "2")

    def button3_clicked(self):
        self.lineEdit_input.setText(self.lineEdit_input.text() + "3")

    def button4_clicked(self):
        self.lineEdit_input.setText(self.lineEdit_input.text() + "4")

    def button5_clicked(self):
        self.lineEdit_input.setText(self.lineEdit_input.text() + "5")

    def button6_clicked(self):
        self.lineEdit_input.setText(self.lineEdit_input.text() + "6")

    def button7_clicked(self):
        self.lineEdit_input.setText(self.lineEdit_input.text() + "7")

    def button8_clicked(self):
        self.lineEdit_input.setText(self.lineEdit_input.text() + "8")

    def button9_clicked(self):
        self.lineEdit_input.setText(self.lineEdit_input.text() + "9")

    def button0_clicked(self):
        self.lineEdit_input.setText(self.lineEdit_input.text() + "0")

    def button_add_clicked(self):
        self.label_output.setText(self.lineEdit_input.text() + " + ")
        self.lineEdit_input.setText("")
        self.lineEdit_input.setFocus()

    def button_sub_clicked(self):
        self.label_output.setText(self.lineEdit_input.text() + " - ")
        self.lineEdit_input.setText("")
        self.lineEdit_input.setFocus()

    def button_mul_clicked(self):
        self.label_output.setText(self.lineEdit_input.text() + " * ")
        self.lineEdit_input.setText("")
        self.lineEdit_input.setFocus()

    def button_div_clicked(self):
        self.label_output.setText(self.lineEdit_input.text() + " / ")
        self.lineEdit_input.setText("")
        self.lineEdit_input.setFocus()

    def equal_clicked(self):
        try:
            result = eval(self.label_output.text() +
                          self.lineEdit_input.text())
        except:
            return
        self.label_output.setText(
            self.label_output.text() + self.lineEdit_input.text() + " = " + str(result))
        self.lineEdit_input.setText("")
        self.label_digit.setText(str(result))
        self.change_label_digit_color(default=False)
        self.lineEdit_input.setFocus()

    def clear_clicked(self):
        self.label_output.setText("")
        self.lineEdit_input.setText("")
        self.label_digit.setText("")
        self.change_label_digit_color(default=True)
        self.lineEdit_input.setFocus()

    def change_label_digit_color(self, default: bool):
        if default:
            self.label_digit.setAutoFillBackground(False)
            self.label_digit.setPalette(self.default_palette)
        else:
            self.label_digit.setAutoFillBackground(True)
            p = self.label_digit.palette()
            p.setColor(self.label_digit.backgroundRole(),
                       QColor(255, 192, 192))
            self.label_digit.setPalette(p)


if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = MainWindow()
    window.show()
    sys.exit(app.exec())
