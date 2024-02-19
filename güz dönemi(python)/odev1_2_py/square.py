from PyQt6.QtCore import *
from PyQt6.QtGui import *
from PyQt6.QtWidgets import *

import sys

from float_validator import FloatValidator


class Square(QWidget):
    def __init__(self) -> None:
        super().__init__()
        self.initUI()

    def initUI(self) -> None:
        square_button = QPushButton("Kare")
        square_button.clicked.connect(self.calculate_square_area_and_perimeter)

        self.a_line_edit = QLineEdit()
        self.a_line_edit.setValidator(FloatValidator())
        a_h_box = QHBoxLayout()
        a_h_box.addWidget(QLabel("a:"))
        a_h_box.addWidget(self.a_line_edit)

        square_v_box = QVBoxLayout()
        square_v_box.addWidget(square_button)
        square_v_box.addLayout(a_h_box)

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

            square_v_box.addLayout(h_boxes[i])

        self.setLayout(square_v_box)

    def calculate_square_area_and_perimeter(self) -> None:
        try:
            a = float(self.a_line_edit.text())
        except ValueError:
            a = None

        if a:
            self.output_line_edits["area"].setText(str(a ** 2))
            self.output_line_edits["perimeter"].setText(str(a * 4))
        else:
            for line_edit in self.output_line_edits.values():
                line_edit.setText("Hata!")


if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = Square()
    window.show()
    sys.exit(app.exec())
