from PyQt6.QtCore import *
from PyQt6.QtGui import *
from PyQt6.QtWidgets import *

import sys

from custom_line_edit import CustomLineEdit
from base_window import BaseWindow


class EquationWindow(BaseWindow):
    def __init__(self) -> None:
        super().__init__()
        self.initUI()

    def initUI(self) -> None:
        inputs_v_box = QVBoxLayout()

        self.input_line_edits: dict[str, CustomLineEdit] = {}
        h_boxes = []

        for i, name in enumerate(["a", "b", "c"]):
            self.input_line_edits[name] = CustomLineEdit()

            h_boxes.append(QHBoxLayout())
            h_boxes[i].addWidget(QLabel(f"{name}:"))
            h_boxes[i].addWidget(self.input_line_edits[name])

            inputs_v_box.addLayout(h_boxes[i])

        calculate_button = QPushButton("Kök bul")
        calculate_button.setSizePolicy(
            QSizePolicy.Policy.Fixed, QSizePolicy.Policy.Fixed)
        calculate_button.clicked.connect(self.calculate)

        outputs_v_box = QVBoxLayout()

        self.output_line_edits: dict[str, QLineEdit] = {}
        h_boxes = []

        for i, (name, string) in enumerate({
            "x1": "x1 sonuç",
            "x2": "x2 sonuç",
        }.items()):
            self.output_line_edits[name] = QLineEdit()
            self.output_line_edits[name].setReadOnly(True)

            h_boxes.append(QHBoxLayout())
            h_boxes[i].addWidget(QLabel(f"{string}:"))
            h_boxes[i].addWidget(self.output_line_edits[name])

            outputs_v_box.addLayout(h_boxes[i])

        inputs_and_outputs_v_box = QVBoxLayout()
        inputs_and_outputs_v_box.addLayout(inputs_v_box)
        inputs_and_outputs_v_box.addWidget(
            calculate_button, alignment=Qt.AlignmentFlag.AlignRight)
        inputs_and_outputs_v_box.addStretch()
        inputs_and_outputs_v_box.addLayout(outputs_v_box)

        image_label = QLabel()
        image_label.setPixmap(QPixmap("images/equation_large.png"))

        io_and_image_h_box = QHBoxLayout()
        io_and_image_h_box.addLayout(inputs_and_outputs_v_box)
        io_and_image_h_box.addWidget(image_label)

        home_page_button = QPushButton("Ana Sayfa")
        home_page_button.clicked.connect(self.return_to_home_page)
        home_page_button.setSizePolicy(
            QSizePolicy.Policy.Expanding, QSizePolicy.Policy.Fixed)

        v_box = QVBoxLayout()
        v_box.addLayout(io_and_image_h_box)
        v_box.addWidget(home_page_button)

        self.setLayout(v_box)

    def calculate(self) -> None:
        try:
            a = float(self.input_line_edits["a"].text())
            b = float(self.input_line_edits["b"].text())
            c = float(self.input_line_edits["c"].text())
        except ValueError:
            a = b = c = 0

        if a and b and c:
            delta = b ** 2 - 4 * a * c

            if delta > 0:
                x1 = (-b + delta ** 0.5) / (2 * a)
                x2 = (-b - delta ** 0.5) / (2 * a)

                self.output_line_edits["x1"].setText(str(x1))
                self.output_line_edits["x2"].setText(str(x2))
            elif delta == 0:
                x = -b / (2 * a)

                for line_edit in self.output_line_edits.values():
                    line_edit.setText(str(x))
            else:
                for line_edit in self.output_line_edits.values():
                    line_edit.setText("Reel kök yok")
        else:
            for line_edit in self.output_line_edits.values():
                line_edit.setText("Hata!")


if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = EquationWindow()
    window.show()
    sys.exit(app.exec())
