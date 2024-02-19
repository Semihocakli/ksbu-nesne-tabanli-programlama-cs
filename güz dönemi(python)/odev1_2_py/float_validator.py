from PyQt6.QtCore import *
from PyQt6.QtGui import *
from PyQt6.QtWidgets import *


class FloatValidator(QValidator):
    def validate(self, input_str, pos):
        if not input_str.strip():
            return QValidator.State.Intermediate, input_str, pos
        try:
            float(input_str)
            return QValidator.State.Acceptable, input_str, pos
        except ValueError:
            return QValidator.State.Invalid, input_str, pos
