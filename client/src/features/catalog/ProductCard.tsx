import { Avatar, Button, Card, CardActions, CardContent, CardMedia, Typography, CardHeader } from "@mui/material";
import { Product } from "../../app/models/product";
import { Link } from "react-router-dom";
import { LoadingButton } from "@mui/lab";
import { currencyFormat } from "../../app/util/util";
import { useAppDispatch, useAppSelector } from "../../app/store/configureStore";
import { addBasketitemAsync, setBasket } from "../basket/basketSlice";

interface Props{
    product:Product;
}

export default function ProductCard({product}: Props){
  const {status} = useAppSelector(state => state.basket);
  const dispatch = useAppDispatch();


  
    return(
        <Card >
            <CardHeader
                avatar={
                    <Avatar sx={{bgcolor:'secondary.main'}}>
                        {product.name.charAt(0).toUpperCase()}
                    </Avatar>
                }
                title={product.name}
                titleTypographyProps={{
                    sx:{fontWeight:'bold',color:'primary.main'}
                }}
            />
      <CardMedia
        sx={{ height: 140, backgroundSize:'contain' }}
        image={product.pictureUrl}
        title={product.name}
      />
      <CardContent>
        <Typography gutterBottom color='secondary' variant="h5" >
          {currencyFormat(product.price)}
        </Typography>
        <Typography variant="body2" color="text.secondary">
          {product.author} / {product.genre}
        </Typography>
      </CardContent>
      <CardActions>
        <LoadingButton 
        loading={status.includes('pendingAddItem' + product.id)} 
        onClick={() => dispatch(addBasketitemAsync({productId :product.id}))} 
        size="small">Add to Cart</LoadingButton>
        <Button component={Link} to={`/catalog/${product.id}`} size="small">View</Button>
      </CardActions>
    </Card>
    )
}
