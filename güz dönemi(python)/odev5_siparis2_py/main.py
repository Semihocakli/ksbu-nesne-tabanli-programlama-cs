from PyQt6.QtCore import *
from PyQt6.QtGui import *
from PyQt6.QtWidgets import *
from PyQt6 import uic
from main_ui import Ui_Form

import sys
from icecream import ic


def get_index_of_selected_item(list_widget: QListWidget) -> int:
    return [list_widget.row(i) for i in list_widget.selectedItems()][0]


def get_index_of_radio_button(group_box: QGroupBox) -> int:
    return [i.isChecked() for i in group_box.findChildren(QRadioButton)].index(True)


def get_check_states_of_check_box(group_box: QGroupBox) -> list[bool]:
    return [i.isChecked() for i in group_box.findChildren(QCheckBox)]


class Main(QWidget):
    def __init__(self):
        super().__init__()
        self.ui = uic.loadUi("main.ui", self)

        self.ui.pushButton.clicked.connect(self.calculate)
        self.ui.pushButton_2.clicked.connect(self.clear)
        self.ui.pushButton_3.clicked.connect(self.close)

    def clear(self):
        for i in [self.ui.lineEdit, self.ui.lineEdit_2]:
            i.clear()

        for i in [self.ui.listWidget.selectedItems(),
                  self.ui.listWidget_2.selectedItems()]:
            for j in i:
                j.setSelected(False)

        for i in [self.ui.groupBox.findChildren(QRadioButton),
                  self.ui.groupBox_2.findChildren(QRadioButton),
                  self.ui.groupBox_3.findChildren(QRadioButton)]:
            for j in i:
                j.setAutoExclusive(False)
                j.setChecked(False)

    def calculate(self):
        try:
            listWidget_index = get_index_of_selected_item(self.ui.listWidget)
            groupBox_index = get_index_of_radio_button(self.ui.groupBox)
            groupBox_3_index = get_index_of_radio_button(self.ui.groupBox_3)
            listWidget2_index = get_index_of_selected_item(self.ui.listWidget_2)
        except IndexError:
            QMessageBox.critical(self, "Hata", "Bütün alanları doldurunuz.")
            return

        ad = self.ui.lineEdit.text()
        soyad = self.ui.lineEdit_2.text()

        if not all([ad, soyad]):
            QMessageBox.critical(self, "Hata", "Bütün alanları doldurunuz.")
            return

        price: float = 0

        price += {
            0: 50,
            1: 100,
            2: 150,
        }[listWidget_index]

        price *= {
            0: 1,
            1: 2,
        }[groupBox_index]

        d = {
            0: 10,
            1: 20,
        }
        for i, check_state in enumerate(get_check_states_of_check_box(self.ui.groupBox_2)):
            if check_state:
                price -= d[i]

        price += {
            0: -10,
            1: 10,
            2: 0,
        }[groupBox_3_index]

        price += {
            0: -(price * 0.1),
            1: 0,
            2: price * 0.1,
        }[listWidget2_index]

        ic(price)

        self.ui.label_5.setText(ad)
        self.ui.label_6.setText(soyad)
        self.ui.label_7.setText(f"{price:.2f} TL")


if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = Main()
    window.show()
    sys.exit(app.exec())
