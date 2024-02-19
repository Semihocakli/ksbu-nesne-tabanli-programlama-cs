from PyQt6.QtCore import *
from PyQt6.QtGui import *
from PyQt6.QtWidgets import *

import sys
import math

from custom_line_edit import CustomLineEdit
from base_window import BaseWindow


class SphereWindow(BaseWindow):
    def __init__(self) -> None:
        super().__init__()
        self.initUI()

    def initUI(self) -> None:
        image_label = QLabel()
        image_label.setPixmap(QPixmap("images/sphere_equation.jpg"))

        inputs_v_box = QVBoxLayout()

        self.input_line_edits: dict[str, CustomLineEdit] = {}
        h_boxes = []

        for i, (name, string) in enumerate({
            "r": "Yarıçap",
            "pi": "π",
        }.items()):
            self.input_line_edits[name] = CustomLineEdit()

            h_boxes.append(QHBoxLayout())
            h_boxes[i].addWidget(QLabel(f"{string}:"))
            h_boxes[i].addWidget(self.input_line_edits[name])

            inputs_v_box.addLayout(h_boxes[i])

        self.input_line_edits["pi"].setText(str(math.pi))

        calculate_button = QPushButton("Hesapla")
        calculate_button.clicked.connect(self.calculate)
        inputs_v_box.addWidget(
            calculate_button, alignment=Qt.AlignmentFlag.AlignRight)

        results_v_box = QVBoxLayout()

        self.output_line_edits: dict[str, QLineEdit] = {}
        h_boxes = []

        for i, (name, string) in enumerate({
            "surface_area": "Yüzey Alanı",
            "cross_sectional_area": "Kesit Alanı",
            "volume": "Hacim",
        }.items()):
            self.output_line_edits[name] = QLineEdit()
            self.output_line_edits[name].setReadOnly(True)

            h_boxes.append(QHBoxLayout())
            h_boxes[i].addWidget(QLabel(f"{string}:"))
            h_boxes[i].addWidget(self.output_line_edits[name])

            results_v_box.addLayout(h_boxes[i])

        input_and_results_h_box = QHBoxLayout()
        input_and_results_h_box.addLayout(inputs_v_box)
        input_and_results_h_box.addStretch()
        input_and_results_h_box.addLayout(results_v_box)

        home_page_button = QPushButton("Ana Sayfa")
        home_page_button.clicked.connect(self.return_to_home_page)

        v_box = QVBoxLayout()
        v_box.addWidget(image_label, alignment=Qt.AlignmentFlag.AlignCenter)
        v_box.addLayout(input_and_results_h_box)
        v_box.addWidget(home_page_button)

        self.setLayout(v_box)

    def calculate(self) -> None:
        try:
            r = float(self.input_line_edits["r"].text())
            pi = float(self.input_line_edits["pi"].text())
        except ValueError:
            r = pi = None

        if r and pi:
            self.output_line_edits["surface_area"].setText(str(4 * pi * r**2))
            self.output_line_edits["cross_sectional_area"].setText(
                str(pi * r**2))
            self.output_line_edits["volume"].setText(str(4 / 3 * pi * r**3))
        else:
            for line_edit in self.output_line_edits.values():
                line_edit.setText("Hata!")


if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = SphereWindow()
    window.show()
    sys.exit(app.exec())
