
var ww = document.body.clientWidth;//$(window).width();

$(document).ready(function() {
	$(".menu li a").each(function() {
		if ($(this).next().length > 0) {
			$(this).addClass("parent");
		};
	})
	
	$(".toggleMenu").click(function(e) {
		e.preventDefault();
		$(this).toggleClass("active");
		$(".menu").toggle();
	});
	adjustMenu();
})

$(window).bind('resize orientationchange', function() {
    ww = document.body.clientWidth;// $(window).width();
	adjustMenu();
});



var adjustMenu = function() {
	if (ww < 768) {
		$(".toggleMenu").css("display", "block");
		
		if (!$(".toggleMenu").hasClass("active")) {
			$(".menu").hide();
		} else {
			$(".menu").show();
		}
		$(".menu li").unbind('mouseenter mouseleave');
		
		$(".menu li a.parent").unbind('click').bind('click', function(e) {
			var istoggle =$(this).parent("li").hasClass("hover");
			
			$(".menu li").removeClass("hover");
			// must be attached to anchor element to prevent bubbling
			e.preventDefault();
			if(istoggle){
				$(this).parent("li").addClass("hover");
			}
			$(this).parent("li").toggleClass("hover");
		});
	} 
	else if (ww >= 768) {
		$(".toggleMenu").css("display", "none");
				
		$(".menu").show();
		$(".menu li").removeClass("hover");
		$(".menu li a").unbind('click');
		$(".menu li").hover(
		function () {
		$(this).addClass('hover', 1000);
		},
		function () {
		$(this).removeClass("hover", 1000);
		});
	}
}

