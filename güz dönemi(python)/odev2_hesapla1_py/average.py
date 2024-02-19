from PyQt6.QtCore import *
from PyQt6.QtGui import *
from PyQt6.QtWidgets import *

import sys

from float_validator import FloatValidator


class AverageWindow(QWidget):
    def __init__(self) -> None:
        super().__init__()
        self.setMinimumSize(QSize(400, 300))
        self.setWindowTitle('Ortalama Hesaplama')
        self.initUI()

    def initUI(self) -> None:
        inputs_v_box = QVBoxLayout()

        self.input_line_edits: dict[str, QLineEdit] = {}
        h_boxes = []

        for i in range(1, 4):
            self.input_line_edits[f'input_{i}'] = QLineEdit()
            self.input_line_edits[f'input_{i}'].setValidator(FloatValidator())

            h_boxes.append(QHBoxLayout())
            h_boxes[i - 1].addWidget(QLabel(f'{i}. sayıyı giriniz:'))
            h_boxes[i - 1].addWidget(self.input_line_edits[f'input_{i}'])

            inputs_v_box.addLayout(h_boxes[i - 1])

        average_calculation_button = QPushButton('Ortalama Hesapla')
        average_calculation_button.clicked.connect(self.calculate_average)

        self.result_line_edit = QLineEdit()
        self.result_line_edit.setReadOnly(True)

        result_h_box = QHBoxLayout()
        result_h_box.addWidget(QLabel('Sonuç:'))
        result_h_box.addWidget(self.result_line_edit)

        clear_button = QPushButton('Temizle')
        clear_button.clicked.connect(self.clear)

        home_button = QPushButton('Ana Sayfa')
        home_button.clicked.connect(self.return_to_home)

        close_button = QPushButton('Kapat')
        close_button.clicked.connect(self.close)

        close_and_home_button_h_box = QHBoxLayout()
        close_and_home_button_h_box.addWidget(home_button)
        close_and_home_button_h_box.addWidget(close_button)

        v_box = QVBoxLayout()
        v_box.addLayout(inputs_v_box)
        v_box.addWidget(average_calculation_button,
                        alignment=Qt.AlignmentFlag.AlignRight)
        v_box.addLayout(result_h_box)
        v_box.addWidget(clear_button, alignment=Qt.AlignmentFlag.AlignRight)
        v_box.addLayout(close_and_home_button_h_box)

        self.setLayout(v_box)

    def return_to_home(self) -> None:
        from main import MainWindow

        self.main_window = MainWindow()
        self.main_window.show()
        self.close()

    def calculate_average(self) -> None:
        numbers = [float(line_edit.text()) for line_edit in self.input_line_edits.values(
        ) if line_edit.text().strip()]

        try:
            self.result_line_edit.setText(str(sum(numbers) / len(numbers)))
        except (ZeroDivisionError or ValueError):
            self.result_line_edit.setText('Hata!')

    def clear(self) -> None:
        for line_edit in self.input_line_edits.values():
            line_edit.clear()
        self.result_line_edit.clear()


if __name__ == '__main__':
    app = QApplication(sys.argv)
    window = AverageWindow()
    window.show()
    sys.exit(app.exec())
