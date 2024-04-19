import { StyleSheet, Text, View } from "react-native"

const Jogos = ({ name, description, classification }) => {
    return (
        <View style={styles.container}>
            <Text style={styles.text}>Nome: {name}</Text>
            <Text style={styles.text}>Descrição: {description}</Text>
            <Text style={styles.text}>Classificação: {classification}</Text>
        </View>
    )
};

const styles = StyleSheet.create({
    container: {
        backgroundColor: 'black',
        margin: 10,
        borderRadius: 8
    },
    text: {
        fontFamily: 'Poppins_900Black_Italic',
        fontSize: 20,
        color: 'red'
    }
})

export default Jogos;