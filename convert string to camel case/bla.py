

def camel(text):
    if len(text) == 0:
        return ""
    
    if text.__contains__("-") or text.__contains__("_"):
        bla = text.replace("-", " ")
        bla = bla.replace("_", " ")

        lst = bla.split(' ')
        result = ""
        result += lst[0]
        for index in range(1, len(lst)):
            result += (lst[index][0]).upper() + lst[index][1:]
        return result
        
#string = "The-stealth-warrior"
string = "The-cat_Is_evil"
string.__contains__("-")
print(camel(string))