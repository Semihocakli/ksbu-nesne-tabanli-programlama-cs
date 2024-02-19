from PyQt6.QtCore import *
from PyQt6.QtGui import *
from PyQt6.QtWidgets import *


def get_focused_widget():
    app = QApplication.instance()
    if app is not None:
        focused_widget = app.focusWidget()
        if focused_widget is not None:
            return focused_widget


class BaseWindow(QWidget):
    def __init__(self) -> None:
        super().__init__()

    def keyPressEvent(self, a0: QKeyEvent | None) -> None:
        if a0.key() == Qt.Key.Key_Escape:
            self.return_to_home_page()

        if a0 and a0.key() == Qt.Key.Key_Enter or a0.key() == Qt.Key.Key_Return:
            focused_widget = get_focused_widget()
            if focused_widget and isinstance(focused_widget, QLineEdit):
                focused_widget.focusNextChild()

        if a0 and a0.key() == Qt.Key.Key_Control:
            focused_widget = get_focused_widget()
            if focused_widget and isinstance(focused_widget, QLineEdit):
                focused_widget.focusPreviousChild()

        return super().keyPressEvent(a0)

    def return_to_home_page(self) -> None:
        from main import MainWindow

        self.window = MainWindow()
        self.window.show()
        self.close()
