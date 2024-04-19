import { View } from "react-native";
import { BoxInput } from "../../BoxInput/Index";
import { ScroolForm, ContainerForm, ContainerInput } from "./style";
import { useEffect, useState } from "react";
import api from "../../services/service";

export function Home() {
    const [cep, setCep] = useState('');
    // const [logradouro, setLogradouro] = useState();
    // const [bairro, setBairro] = useState();
    // const [cidade, setCidade] = useState();
    // const [estado, setEstado] = useState();
    // const [uf, setUf] = useState();

    const [dados, setDados] = useState({});

    const chamarApi = async () => {
        if (cep.length < 8) {
            setDados({})
            return
        }

        try {
            const promise = await api.get(cep)

            const retornoApi = promise.data.result;

            setDados({
                rua: retornoApi.street,
                bairro: retornoApi.district,
                cidade: retornoApi.city,
                estado: retornoApi.state,
                uf: retornoApi.stateShortname,
            })
        } catch (error) {
            console.log(error)
        }
    }
    useEffect(() => {
        chamarApi()
    }, [cep])

    return (
        <ScroolForm>
            <ContainerForm>
                <BoxInput
                    textLabel='Informar CEP'
                    editable={true}
                    placeholder='Cep...'
                    keyType='numeric'
                    maxLength={8}
                    fieldvalue={cep}
                    onChangeText={tx => setCep(tx)}
                />
                <BoxInput
                    textLabel='Logradouro'
                    editable={false}
                    placeholder='Logradouro'
                    fieldvalue={dados.rua}
                />
                <BoxInput
                    textLabel='Bairro'
                    editable={false}
                    placeholder='Bairro'
                    fieldvalue={dados.bairro}
                />
                <BoxInput
                    textLabel='Cidade'
                    editable={false}
                    placeholder='Cidade'
                    fieldvalue={dados.cidade}
                />
                <ContainerInput>
                    <BoxInput
                        textLabel='Estado'
                        placeholder='Estado...'
                        editable={false}
                        fieldWidth={67}
                        fieldvalue={dados.estado}
                    />
                    <BoxInput
                        textLabel='UF'
                        placeholder='UF'
                        editable={false}
                        fieldWidth={25}
                        fieldvalue={dados.uf}
                    />
                </ContainerInput>
            </ContainerForm>
        </ScroolForm>
    )
}