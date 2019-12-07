from abc import ABCMeta, abstractmethod
class Book(object, metaclass=ABCMeta):
    def __init__(self,title,author):
        self.title=title
        self.author=author   
    @abstractmethod
    def display(): pass

class MyBook(Book):
    def __init__(self, title, author, price):
        super().__init__(title, author)
        self.price = price

    def display(self):

        print("Title: " + self.title, end = '\n')
        print("Author: " + self.author, end = '\n')
        print("Price: " + str(self.price), end = '\n')

title=input()
author=input()
price=int(input())
new_novel=MyBook(title,author,price)
new_novel.display()