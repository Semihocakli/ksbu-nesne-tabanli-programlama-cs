from PyQt6.QtCore import *
from PyQt6.QtGui import *
from PyQt6.QtWidgets import *

import sys


class FactorialWindow(QWidget):
    def __init__(self) -> None:
        super().__init__()
        self.setMinimumSize(QSize(400, 300))
        self.setWindowTitle('Faktöriyel Hesaplama')
        self.initUI()

    def initUI(self) -> None:
        input_h_box = QHBoxLayout()

        self.input_line_edit = QLineEdit()
        self.input_line_edit.setValidator(QIntValidator())

        input_h_box.addWidget(QLabel('Sayıyı giriniz:'))
        input_h_box.addWidget(self.input_line_edit)

        calculation_button = QPushButton('Hesapla')
        calculation_button.clicked.connect(self.calculate_factorial)

        result_h_box = QHBoxLayout()

        self.result_line_edit = QLineEdit()
        self.result_line_edit.setReadOnly(True)

        result_h_box.addWidget(QLabel('Sonuç:'))
        result_h_box.addWidget(self.result_line_edit)

        home_button = QPushButton('Ana Sayfa')
        home_button.clicked.connect(self.return_to_home)

        v_box = QVBoxLayout()
        v_box.addLayout(input_h_box)
        v_box.addWidget(calculation_button,
                        alignment=Qt.AlignmentFlag.AlignRight)
        v_box.addLayout(result_h_box)
        v_box.addWidget(home_button)

        self.setLayout(v_box)

    def return_to_home(self) -> None:
        from main import MainWindow

        self.main_window = MainWindow()
        self.main_window.show()
        self.close()

    def calculate_factorial(self) -> None:
        input_text = self.input_line_edit.text()
        if not input_text.strip():
            return

        number = int(input_text)
        factorial = 1

        for i in range(1, number + 1):
            factorial *= i

        self.result_line_edit.setText(str(factorial))


if __name__ == '__main__':
    app = QApplication(sys.argv)
    window = FactorialWindow()
    window.show()
    sys.exit(app.exec())
