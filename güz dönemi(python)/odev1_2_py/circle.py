from PyQt6.QtCore import *
from PyQt6.QtGui import *
from PyQt6.QtWidgets import *

import sys
import math

from float_validator import FloatValidator


class Circle(QWidget):
    def __init__(self) -> None:
        super().__init__()
        self.initUI()

    def initUI(self) -> None:
        circle_button = QPushButton("Çember")
        circle_button.clicked.connect(self.calculate_circle_area_and_perimeter)

        circle_v_box = QVBoxLayout()
        circle_v_box.addWidget(circle_button)

        self.input_line_edits: dict[str, QLineEdit] = {}
        h_boxes = []

        for i, (name, string) in enumerate({
            "r": "r",
            "pi": "π"
        }.items()):
            self.input_line_edits[name] = QLineEdit()
            self.input_line_edits[name].setValidator(FloatValidator())

            h_boxes.append(QHBoxLayout())
            h_boxes[i].addWidget(QLabel(f"{string}:"))
            h_boxes[i].addWidget(self.input_line_edits[name])

            circle_v_box.addLayout(h_boxes[i])

        self.input_line_edits["pi"].setText(str(math.pi))

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

            circle_v_box.addLayout(h_boxes[i])

        self.setLayout(circle_v_box)

    def calculate_circle_area_and_perimeter(self) -> None:
        try:
            r = float(self.input_line_edits["r"].text())
            pi = float(self.input_line_edits["pi"].text())
        except ValueError:
            r = pi = None

        if r and pi:
            self.output_line_edits["area"].setText(str(pi * r ** 2))
            self.output_line_edits["perimeter"].setText(str(2 * pi * r))
        else:
            for line_edit in self.output_line_edits.values():
                line_edit.setText("Hata!")

    def keyPressEvent(self, event: QKeyEvent) -> None:
        if event.key() == Qt.Key.Key_P:
            self.pi_line_edit.setText(str(math.pi))


if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = Circle()
    window.show()
    sys.exit(app.exec())
