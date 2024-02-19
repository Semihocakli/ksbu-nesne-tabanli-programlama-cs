from PyQt6.QtCore import *
from PyQt6.QtGui import *
from PyQt6.QtWidgets import *

import sys


class Lists(QWidget):
    def __init__(self) -> None:
        super().__init__()
        self.initUI()

    def initUI(self) -> None:
        self.lists: list[QListWidget] = [QListWidget() for _ in range(4)]
        self.lists[0].addItems(["Pizza", "İçecek", "Unlu Mamüller", "Burger"])

        h_box = QHBoxLayout()

        for i, text in zip(self.lists, ["Menü", "Çeşitleri", "Ekstra", "Adet"]):
            v_box = QVBoxLayout()
            v_box.addWidget(QLabel(text))
            v_box.addWidget(i)
            h_box.addLayout(v_box)

        self.setLayout(h_box)

    def clear_lists(self, start_index: int = 0) -> None:
        [i.clear() for i in self.lists[start_index:]]


if __name__ == '__main__':
    app = QApplication(sys.argv)
    window = Lists()
    window.show()
    sys.exit(app.exec())
