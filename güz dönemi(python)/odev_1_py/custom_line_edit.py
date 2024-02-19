from PyQt6.QtCore import *
from PyQt6.QtGui import *
from PyQt6.QtWidgets import *

from float_validator import FloatValidator

class CustomLineEdit(QLineEdit):
    def __init__(self, parent=None):
        super().__init__(parent)
        self.setValidator(FloatValidator())
        self.setStyleSheet("QLineEdit { background-color: white; }")

    def focusInEvent(self, event):
        self.setStyleSheet("QLineEdit { background-color: yellow; }")
        super().focusInEvent(event)

    def focusOutEvent(self, event):
        self.setStyleSheet("QLineEdit { background-color: white; }")
        super().focusOutEvent(event)
