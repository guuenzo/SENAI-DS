import axios from "axios"

const externalApiUri = "https://brasilaberto.com/api/v1/zipcode/";

const api = axios.create({
    baseURL: externalApiUri
})

export default api