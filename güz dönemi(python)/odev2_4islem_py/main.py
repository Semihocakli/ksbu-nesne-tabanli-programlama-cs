from PyQt6.QtCore import *
from PyQt6.QtGui import *
from PyQt6.QtWidgets import *

import sys

from float_validator import FloatValidator


class MainWindow(QWidget):
    def __init__(self) -> None:
        super().__init__()
        self.setWindowTitle("4 İşlem")
        self.initUI()

    def initUI(self):
        self.input_line_edits: dict[str, QLineEdit] = {}
        io_h_box = QHBoxLayout()

        for i in ["a", "b"]:
            self.input_line_edits[i] = QLineEdit()
            self.input_line_edits[i].setValidator(FloatValidator())
            io_h_box.addWidget(self.input_line_edits[i])

        self.output_line_edit = QLineEdit()
        self.output_line_edit.setReadOnly(True)
        io_h_box.addWidget(self.output_line_edit)

        operator_buttons: dict[str, QPushButton] = {}
        operator_h_box = QHBoxLayout()

        for var_name, string in {
            "add": "Topla",
            "subtract": "Çıkar",
            "multiply": "Çarp",
            "divide": "Böl",
        }.items():
            operator_buttons[var_name] = QPushButton(string)
            exec(f"operator_buttons[var_name].clicked.connect(lambda: self.calculate('{var_name}'))", {
                "self": self,
                "var_name": var_name,
                "operator_buttons": operator_buttons,
            })
            operator_h_box.addWidget(operator_buttons[var_name])

        clear_button = QPushButton("Temizle")
        clear_button.clicked.connect(self.clear_output)

        close_button = QPushButton("Kapat")
        close_button.setSizePolicy(
            QSizePolicy.Policy.Minimum, QSizePolicy.Policy.Fixed)
        close_button.clicked.connect(self.close)

        v_box = QVBoxLayout()
        v_box.addLayout(io_h_box)
        v_box.addLayout(operator_h_box)
        v_box.addWidget(clear_button)
        v_box.addWidget(close_button, alignment=Qt.AlignmentFlag.AlignRight)

        self.setLayout(v_box)

    def calculate(self, operator: str):
        try:
            a = float(self.input_line_edits["a"].text())
            b = float(self.input_line_edits["b"].text())
        except ValueError:
            a = b = None

        if a and b:
            if operator == "add":
                result = a + b
            elif operator == "subtract":
                result = a - b
            elif operator == "multiply":
                result = a * b
            elif operator == "divide":
                result = a / b
            self.output_line_edit.setText(str(result))
        else:
            self.output_line_edit.setText("Hata!")

    def clear_output(self):
        self.output_line_edit.clear()
        for line_edit in self.input_line_edits.values():
            line_edit.clear()


if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = MainWindow()
    window.show()
    sys.exit(app.exec())
