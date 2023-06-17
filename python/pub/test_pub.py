import pytest as pytest

from python.pub import pub


def test_one_beer_costs_74():
    price = pub.compute_cost(pub.ONE_BEER, False, 1)
    assert price == 74


def test_one_cider_costs_103():
    price = pub.compute_cost(pub.ONE_CIDER, False, 1)
    assert price == 103


def test_one_proper_cider_costs_110():
    price = pub.compute_cost(pub.A_PROPER_CIDER, False, 1)
    assert price == 110


def test_gin_and_tonic_costs_115():
    price = pub.compute_cost(pub.GT, False, 1)
    assert price == 115


def test_bacardi_special_costs_127():
    price = pub.compute_cost(pub.BACARDI_SPECIAL, False, 1)
    assert price == 127.5


def test_one_beer_costs_students_67():
    price = pub.compute_cost(pub.ONE_BEER, True, 1)
    assert price == 66.6


def test_multiple_beers_gives_students_discounts():
    price = pub.compute_cost(pub.ONE_BEER, True, 2)
    assert price == 66.6 * 2


def test_students_do_not_get_discounts_on_cocktails():
    price = pub.compute_cost(pub.GT, True, 1)
    assert price == 115


def test_ordering_off_menu_throws_error():
    with pytest.raises(ValueError):
        pub.compute_cost('San Francisco Sling', False, 1)


def test_cannot_order_three_cocktails():
    with pytest.raises(ValueError):
        pub.compute_cost(pub.BACARDI_SPECIAL, False, 3)


def test_can_order_more_than_two_beers():
    pub.compute_cost(pub.ONE_BEER, False, 5)
