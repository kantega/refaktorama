ONE_BEER = "hansa"
ONE_CIDER = "grans"
A_PROPER_CIDER = "strongbow"
GT = "gt"
BACARDI_SPECIAL = "bacardi_special"


def compute_cost(drink: str, is_student: bool, amount: int):
    if amount > 2 and (drink == GT or drink == BACARDI_SPECIAL):
        raise ValueError('Too many drinks, max 2.')
    price = 0
    if drink == ONE_BEER:
        price = 74
    elif drink == ONE_CIDER:
        price = 103
    elif drink == A_PROPER_CIDER:
        price = 110
    elif drink == GT:
        price = ingredient6() + ingredient5() + ingredient4()
    elif drink == BACARDI_SPECIAL:
        price = ingredient6() / 2 + ingredient1() + ingredient2() + ingredient3()
    else:
        raise ValueError('No such drink exists')
    if is_student and (drink == ONE_CIDER or drink == ONE_BEER or drink == A_PROPER_CIDER):
        price = price - price / 10
    return price * amount


# One unit of rum
def ingredient1():
    return 65


# One unit of grenadine
def ingredient2():
    return 10


# One unit of juice
def ingredient3():
    return 10


# One unit of green stuff
def ingredient4():
    return 10


# One unit of tonic water
def ingredient5():
    return 20


# One unit of gin
def ingredient6():
    return 85
