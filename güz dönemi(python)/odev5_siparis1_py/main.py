from PyQt6.QtCore import *
from PyQt6.QtGui import *
from PyQt6.QtWidgets import *

import sys
import re

from lists import Lists
from icecream import ic


class Main(QWidget):
    def __init__(self) -> None:
        super().__init__()
        self.initUI()

    def initUI(self) -> None:
        self.lists_widget = Lists()
        self.lists_widget.lists[0].itemClicked.connect(self.list0_item_changed)
        self.lists_widget.lists[1].itemClicked.connect(self.list1_item_changed)
        self.lists_widget.lists[2].itemClicked.connect(self.list2_item_changed)

        close_button = QPushButton("Kapat")
        close_button.clicked.connect(self.close)

        clear_button = QPushButton("Temizle")
        clear_button.clicked.connect(self.lists_widget.clear_lists)

        calculate_button = QPushButton("Hesapla")
        calculate_button.clicked.connect(self.calculate)

        self.result_label = QLabel("Toplam Fiyatı: ")

        h_box = QHBoxLayout()
        h_box.addWidget(close_button)
        h_box.addWidget(clear_button)
        h_box.addWidget(calculate_button)
        h_box.addWidget(self.result_label)

        v_box = QVBoxLayout()
        v_box.addWidget(self.lists_widget)
        v_box.addLayout(h_box)

        self.setLayout(v_box)

    def calculate(self) -> None:
        try:
            selected_items_text: list[str] = [i.currentItem().text() for i in self.lists_widget.lists]
        except AttributeError:
            QMessageBox.critical(self, "Hata", "Lütfen tüm seçimleri yapınız.")
            return

        ic(selected_items_text)

        total_price: int = 0
        for i in selected_items_text:
            match = re.search(r'\((\d+) TL\)', i)
            if match:
                price = int(match.group(1))
                total_price += price
                ic(price, total_price)

        total_price *= int(selected_items_text[-1])
        ic(total_price)
        self.result_label.setText(f"Toplam Fiyatı: {total_price} TL")

    def list0_item_changed(self, item: QListWidgetItem) -> None:
        data: dict[str, list[str]] = {
            "Pizza": ["Küçük Boy (50 TL)", "Orta Boy (60 TL)", "Büyük Boy (70 TL)"],
            "İçecek": ["Kola", "Fanta", "Su"],
            "Unlu Mamüller": ["Simit", "Börek", "Poğaça"],
            "Burger": ["ChickenBurger", "ChessBurger"]
        }

        self.lists_widget.clear_lists(1)
        self.lists_widget.lists[1].addItems(data[item.text()])

    def list1_item_changed(self, item: QListWidgetItem) -> None:
        data: dict[str, list[str]] = {
            # Pizza
            "Küçük Boy (50 TL)": ["Sucuk (10 TL)", "Mantar (5 TL)", "Peynir (4 TL)"],
            "Orta Boy (60 TL)": ["Sucuk (11 TL)", "Mantar (6 TL)", "Peynir (5 TL)"],
            "Büyük Boy (70 TL)": ["Sucuk (12 TL)", "Mantar (7 TL)", "Peynir (6 TL)"],

            # İçecek
            "Kola": ["Küçük Boy (15 TL)", "Orta Boy (16 TL)", "Büyük Boy (17 TL)"],
            "Fanta": ["Küçük Boy (10 TL)", "Orta Boy (11 TL)", "Büyük Boy (12 TL)"],
            "Su": ["Küçük Boy (5 TL)", "Orta Boy (6 TL)", "Büyük Boy (7 TL)"],

            # Unlu Mamüller
            "Simit": ["Susamlı (7 TL)", "Susamlısız (8 TL)"],
            "Börek": ["Kaşarlı (10 TL)", "Peynirli (11 TL)"],
            "Poğaça": ["Zeytinli (7 TL)", "Kaşarlı (10 TL)", "Peynirli (11 TL)"],

            # Burger
            "ChickenBurger": ["Soslu (30 TL)", "Sozsuz (35 TL)"],
            "ChessBurger": ["Biber (20 TL)", "Islak (25 TL)"],
        }

        self.lists_widget.clear_lists(2)
        self.lists_widget.lists[2].addItems(data[item.text()])

    def list2_item_changed(self, item: QListWidgetItem) -> None:
        self.lists_widget.lists[3].clear()
        self.lists_widget.lists[3].addItems(map(str, range(1, 4)))


if __name__ == '__main__':
    app = QApplication(sys.argv)
    window = Main()
    window.show()
    sys.exit(app.exec())
