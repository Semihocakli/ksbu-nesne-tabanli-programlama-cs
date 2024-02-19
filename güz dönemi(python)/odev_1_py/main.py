from square import SquareWindow
from rectangle import RectangleWindow
from cylinder import CylinderWindow
from cone import ConeWindow
from sphere import SphereWindow
from equation import EquationWindow

from PyQt6.QtCore import *
from PyQt6.QtGui import *
from PyQt6.QtWidgets import *

import sys


class MainWindow(QWidget):
    windows: dict = {
        'square': SquareWindow,
        'rectangle': RectangleWindow,
        'cylinder': CylinderWindow,
        'cone': ConeWindow,
        'sphere': SphereWindow,
        'equation': EquationWindow,
    }

    def __init__(self) -> None:
        super().__init__()
        self.initUI()

    def initUI(self) -> None:
        grid = QGridLayout()

        labels = []
        buttons = []

        for i, (name, (string, location)) in enumerate({
            "square": ["Küp", (0, 0)],
            "rectangle": ["Dikdörtgenler P.", (0, 1)],
            "cylinder": ["Silindir", (0, 2)],
            "cone": ["Koni", (1, 0)],
            "sphere": ["Küre", (1, 1)],
            "equation": ["Denklem", (1, 2)],
        }.items()):
            labels.append(QLabel())
            labels[i].setPixmap(QPixmap(f"images/{name}.jpg"))

            buttons.append(QPushButton(string))
            exec(f"buttons[i].clicked.connect(lambda _, window_name='{name}': self.open_window('{name}'))", {
                'self': self,
                'name': name,
                'buttons': buttons,
                'window_name': name,
                'i': i,
            })

            v_box = QVBoxLayout()
            v_box.addWidget(labels[i], alignment=Qt.AlignmentFlag.AlignCenter)
            v_box.addWidget(buttons[i], alignment=Qt.AlignmentFlag.AlignCenter)

            grid.addLayout(v_box, *location)

        self.setLayout(grid)

    def open_window(self, window_name):
        if window_name in self.windows:
            self.window = self.windows[window_name]()
            self.window.show()
            self.close()


if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = MainWindow()
    window.show()
    sys.exit(app.exec())
