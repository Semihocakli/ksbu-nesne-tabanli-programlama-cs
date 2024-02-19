from PyQt6.QtCore import *
from PyQt6.QtGui import *
from PyQt6.QtWidgets import *

import sys

from float_validator import FloatValidator


class Rectangle(QWidget):
    def __init__(self) -> None:
        super().__init__()
        self.initUI()

    def initUI(self) -> None:
        rectangle_button = QPushButton("Dikdörtgen")
        rectangle_button.clicked.connect(
            self.calculate_rectangle_area_and_perimeter)

        rectangle_v_box = QVBoxLayout()
        rectangle_v_box.addWidget(rectangle_button)

        self.input_line_edits: dict[str, QLineEdit] = {}
        h_boxes = []

        for i, name in enumerate(["a", "b"]):
            self.input_line_edits[name] = QLineEdit()
            self.input_line_edits[name].setValidator(FloatValidator())

            h_boxes.append(QHBoxLayout())
            h_boxes[i].addWidget(QLabel(f"{name}:"))
            h_boxes[i].addWidget(self.input_line_edits[name])

            rectangle_v_box.addLayout(h_boxes[i])

        self.output_line_edits: dict[str, QLineEdit] = {}
        h_boxes = []

        for i, (name, string) in enumerate({
            "area": "Alan",
            "perimeter": "Çevre"
        }.items()):
            self.output_line_edits[name] = QLineEdit()
            self.output_line_edits[name].setReadOnly(True)

            h_boxes.append(QHBoxLayout())
            h_boxes[i].addWidget(QLabel(f"{string}:"))
            h_boxes[i].addWidget(self.output_line_edits[name])

            rectangle_v_box.addLayout(h_boxes[i])

        self.setLayout(rectangle_v_box)

    def calculate_rectangle_area_and_perimeter(self) -> None:
        try:
            a = float(self.input_line_edits["a"].text())
            b = float(self.input_line_edits["b"].text())
        except ValueError:
            a = b = None

        if a and b:
            self.output_line_edits["area"].setText(str(a * b))
            self.output_line_edits["perimeter"].setText(str((a + b) * 2))
        else:
            for line_edit in self.output_line_edits.values():
                line_edit.setText("Hata!")


if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = Rectangle()
    window.show()
    sys.exit(app.exec())
