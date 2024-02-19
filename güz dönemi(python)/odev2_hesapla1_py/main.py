from factorial import FactorialWindow
from average import AverageWindow

from PyQt6.QtCore import *
from PyQt6.QtGui import *
from PyQt6.QtWidgets import *

import sys


class MainWindow(QWidget):
    windows = {
        'average': AverageWindow,
        'factorial': FactorialWindow,
    }

    def __init__(self) -> None:
        super().__init__()
        self.setMinimumSize(QSize(400, 300))
        self.setWindowTitle('Ana Sayfa')
        self.initUI()

    def initUI(self) -> None:
        v_box = QVBoxLayout()
        v_box.addStretch()

        buttons: dict[str, QPushButton] = {}

        for name, string in zip(
            self.windows.keys(),
            ["Ortalama Hesaplama", "Faktöriyel Hesaplama", ]
        ):
            buttons[name] = QPushButton(string)
            exec(f"buttons[name].clicked.connect(lambda: self.open_window('{name}'))", {
                'self': self,
                'buttons': buttons,
                'name': name,
            })
            v_box.addWidget(buttons[name])

        v_box.addStretch()

        close_button = QPushButton('Kapat')
        close_button.clicked.connect(self.close)

        v_box.addWidget(close_button, alignment=Qt.AlignmentFlag.AlignRight)

        self.setLayout(v_box)

    def open_window(self, window_name) -> None:
        if window_name in self.windows:
            self.window = self.windows[window_name]()
            self.window.show()
            self.close()


if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = MainWindow()
    window.show()
    sys.exit(app.exec())
