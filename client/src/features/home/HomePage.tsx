import { Box, Typography } from "@mui/material";
import Slider from "react-slick";

export default function HomePage(){
    const settings = {
        dots: true,
        infinite: true,
        speed: 500,
        slidesToShow: 1,
        slidesToScroll: 1
      };
    return (
       <>
            <Slider {...settings}>
                <div>
                    <img src="/images/Slider_Image_27_Short_Crime_Reads-960x430.png" alt="book1" style={{display: 'block', width:'100%', maxHeight:500}} />
                </div>
                <div>
                    <img src="/images/sliderbook.jpg" alt="book2" style={{display: 'block', width:'100%', maxHeight:500}} />
                </div>
                <div>
                    <img src="/images/ASHOKA BOOK_WEB SLIDER.png" alt="book3" style={{display: 'block', width:'100%', maxHeight:500}} />
                </div>
            </Slider>
            <Box display='flex' justifyContent='center' sx={{p: 4}}>
                <Typography variant = 'h1'>
                    Welcome to the shop!
                </Typography>
            </Box>
       </>
    )
}