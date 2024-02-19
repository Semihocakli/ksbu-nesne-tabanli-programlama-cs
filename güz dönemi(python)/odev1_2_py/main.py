from circle import Circle
from square import Square
from rectangle import Rectangle
from triangle import Triangle

from PyQt6.QtCore import *
from PyQt6.QtGui import *
from PyQt6.QtWidgets import *

import sys


class MainWindow(QMainWindow):
    def __init__(self) -> None:
        super().__init__()
        self.initUI()

    def initUI(self) -> None:
        grid = QGridLayout()

        for i, widget in enumerate([Triangle, Rectangle, Square, Circle]):
            grid.addWidget(widget(), i // 2, i % 2)

        widget = QWidget()
        widget.setLayout(grid)
        self.setCentralWidget(widget)


if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = MainWindow()
    window.show()
    sys.exit(app.exec())
