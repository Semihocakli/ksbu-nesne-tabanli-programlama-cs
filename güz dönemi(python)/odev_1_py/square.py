from PyQt6.QtCore import *
from PyQt6.QtGui import *
from PyQt6.QtWidgets import *

import sys

from custom_line_edit import CustomLineEdit
from base_window import BaseWindow


class SquareWindow(BaseWindow):
    def __init__(self) -> None:
        super().__init__()
        self.initUI()

    def initUI(self) -> None:
        image_label = QLabel()
        image_label.setPixmap(QPixmap("images/square_equation.jpg"))

        self.a_line_edit = CustomLineEdit()

        line_edit_h_box = QHBoxLayout()
        line_edit_h_box.addWidget(QLabel("a:"))
        line_edit_h_box.addWidget(self.a_line_edit)

        calculate_button = QPushButton("Hesapla")
        calculate_button.clicked.connect(self.calculate)

        inputs_v_box = QVBoxLayout()
        inputs_v_box.addLayout(line_edit_h_box)
        inputs_v_box.addWidget(
            calculate_button, alignment=Qt.AlignmentFlag.AlignRight)

        results_v_box = QVBoxLayout()

        self.output_line_edits: dict[str, QLineEdit] = {}
        h_boxes = []

        for i, (name, string) in enumerate({
            "surface_area": "Yüzey Alanı",
            "cross_sectional_area": "Kesit Alanı",
            "cube_volume": "Küp Hacmi",
        }.items()):
            self.output_line_edits[name] = QLineEdit()
            self.output_line_edits[name].setReadOnly(True)

            h_boxes.append(QHBoxLayout())

            l = QLabel(f"{string}:")
            l.setStyleSheet("color: red;")

            h_boxes[i].addWidget(l)
            
            
            
            h_boxes[i].addWidget(self.output_line_edits[name])

            results_v_box.addLayout(h_boxes[i])

        input_and_results_h_box = QHBoxLayout()
        input_and_results_h_box.addLayout(inputs_v_box)
        input_and_results_h_box.addStretch()
        input_and_results_h_box.addLayout(results_v_box)

        home_page_button = QPushButton("Ana Sayfa")
        home_page_button.clicked.connect(self.return_to_home_page)
        home_page_button.setSizePolicy(
            QSizePolicy.Policy.Expanding, QSizePolicy.Policy.Fixed)

        v_box = QVBoxLayout()
        v_box.addWidget(image_label, alignment=Qt.AlignmentFlag.AlignCenter)
        v_box.addLayout(line_edit_h_box)
        v_box.addLayout(input_and_results_h_box)
        v_box.addWidget(home_page_button)

        self.setLayout(v_box)

    def calculate(self) -> None:
        try:
            a = float(self.a_line_edit.text())
        except ValueError:
            a = None

        if a:
            self.output_line_edits["surface_area"].setText(str(6 * a ** 2))
            self.output_line_edits["cross_sectional_area"].setText(str(a ** 2))
            self.output_line_edits["cube_volume"].setText(str(a ** 3))
        else:
            for line_edit in self.output_line_edits.values():
                line_edit.setText("Hata!")


if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = SquareWindow()
    window.show()
    sys.exit(app.exec())
