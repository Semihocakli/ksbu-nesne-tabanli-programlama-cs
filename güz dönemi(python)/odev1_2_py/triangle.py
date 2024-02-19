from PyQt6.QtCore import *
from PyQt6.QtGui import *
from PyQt6.QtWidgets import *

import sys

from float_validator import FloatValidator


class Triangle(QWidget):
    def __init__(self) -> None:
        super().__init__()
        self.initUI()

    def initUI(self) -> None:
        triangle_button = QPushButton("Üçgen")
        triangle_button.clicked.connect(self.calculate_triangle_perimeter)

        triangle_v_box = QVBoxLayout()
        triangle_v_box.addWidget(triangle_button)

        self.input_line_edits: dict[str, QLineEdit] = {}
        h_boxes = []

        for i, name in enumerate(["a", "b", "c"]):
            self.input_line_edits[name] = QLineEdit()
            self.input_line_edits[name].setValidator(FloatValidator())

            h_boxes.append(QHBoxLayout())
            h_boxes[i].addWidget(QLabel(f"{name}:"))
            h_boxes[i].addWidget(self.input_line_edits[name])

            triangle_v_box.addLayout(h_boxes[i])

        result_h_box = QHBoxLayout()
        result_h_box.addWidget(QLabel("Çevre:"))
        self.result_line_edit = QLineEdit()
        self.result_line_edit.setReadOnly(True)
        self.result_line_edit.setValidator(FloatValidator())

        result_h_box.addWidget(self.result_line_edit)
        triangle_v_box.addLayout(result_h_box)

        self.setLayout(triangle_v_box)

    def calculate_triangle_perimeter(self) -> None:
        try:
            a = float(self.input_line_edits["a"].text())
            b = float(self.input_line_edits["b"].text())
            c = float(self.input_line_edits["c"].text())
        except ValueError:
            a = b = c = None

        if a and b and c:
            self.result_line_edit.setText(str(a + b + c))
        else:
            self.result_line_edit.setText("Hata!")


if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = Triangle()
    window.show()
    sys.exit(app.exec())
