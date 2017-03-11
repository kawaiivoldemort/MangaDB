var $jq = jQuery.noConflict();

$jq(document).ready(function () {
    $jq('#advertSlider').slick({
        dots: true,
        infinite: true,
        speed: 300,
        slidesToShow: 1,
        autoplay: true,
        autoplaySpeed: 2000,
    });
    $jq('#newSlider').slick({
        centerMode: true,
        centerPadding: '60px',
        infinite: true,
        slidesToShow: 3,
        responsive: [
            {
                breakpoint: 768,
                settings: {
                    arrows: false,
                    centerMode: true,
                    centerPadding: '40px',
                    slidesToShow: 3
                }
            },
            {
                breakpoint: 480,
                settings: {
                    arrows: false,
                    centerMode: true,
                    centerPadding: '40px',
                    slidesToShow: 1
                }
            }
        ],
        autoplay: true,
        autoplaySpeed: 2000,
    });
    $jq('#trendingSlider').slick({
        vertical: true,
        verticalSwiping: true,
        arrows: false,
        infinite: true,
        speed: 300,
        slidesToShow: 3,
        autoplay: true,
        autoplaySpeed: 8000,
    });
    $jq('#allTimeFavoritesSlider').slick({
        vertical: true,
        verticalSwiping: true,
        appendArrows: "htmlString",
        infinite: true,
        speed: 300,
        slidesToShow: 3,
        autoplay: true,
        autoplaySpeed: 8000,
    });
});